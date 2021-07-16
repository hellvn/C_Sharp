using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;
using System.Dynamic;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Product
        public ActionResult Index(string search, string sortOrder, string categoryId)
        {
            ViewBag.CategoryId = 0;
            string sort = !string.IsNullOrEmpty(sortOrder) ? sortOrder : "asc";


            //cach 1 dung thang dbSet
            //if (!string.IsNullOrEmpty(search))
            //{
            //    var products = db.Products.Where(p => p.Name.Contains(search)).OrderBy(p=> p.Name).ToList();
            //    return View(products);
            //}

            //return View(db.Products.OrderBy(p => p.Name).ToList());

            //cach 2 dung dbRaw
            var products = from p in db.Products select p;
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search));
            }
            switch (sort)
            {
                case "asc": products = products.OrderBy(p => p.Name);
                    break;
                case "desc": products = products.OrderByDescending(p => p.Name);
                    break;
            }
            // loc theo category
            if (!string.IsNullOrEmpty(categoryId))
            {
                var catId = Convert.ToInt32(categoryId);
                products = products.Where(p => p.CategoryId == catId);
                ViewBag.CategoryId = catId;
            }


            var categories = db.Categories.ToList();
            dynamic data = new ExpandoObject();
            data.Products = products;
            data.Categories = categories;
            return View(data);
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult AddToCart(int? id, int? qty)
        {
            try
            {
                Product product = db.Products.Find(id);
                if(product == null)
                {
                    return HttpNotFound();
                }
                //them vao gio hang
                CartItem item = new CartItem(product, (int)qty);
                //lay gio hang tu session
                Cart cart = (Cart)Session["Cart"];
                if (cart == null)
                {
                    Customer customer = new Customer("Nguyen Van A", "0123456789", "8A Ton That Thuyet");
                    cart = new Cart();
                }
                cart.AddToCart(item);
                Session["cart"] = cart;
            }
            catch(Exception)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Cart");
        }
        public ActionResult RemoveItem(int? id)
        {
            try
            {

                Cart cart = (Cart)Session["Cart"];
                if (cart == null)
                {
                    return HttpNotFound();
                }
                cart.RemoveItem((int)id);
                Session["cart"] = cart;// theem session
            }
            catch (Exception)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Cart");
        }

        public ActionResult Cart()
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(db.Brands, "id", "BrandName");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Image,Price,Description,CategoryId,BrandId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.Brands, "id", "BrandName", product.BrandId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandId = new SelectList(db.Brands, "id", "BrandName", product.BrandId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Image,Price,Description,CategoryId,BrandId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.Brands, "id", "BrandName", product.BrandId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut(Order order)
        {
            if (ModelState.IsValid)
            {
                var cart = (Cart)Session["cart"];
                order.GrandTotal = cart.GrandTotal;
                order.CreatedAt = DateTime.Now;
                order.Status = 1;
                db.Orders.Add(order);
                db.SaveChanges();

                foreach(var item in cart.cartItems)
                {
                    OrderItem orderItem = new OrderItem() { OrderID = order.Id, ProductID = item.Product.Id, Qty = item.Quantity, Price = item.Product.Price };
                    db.OrderItems.Add(orderItem);
                }
                db.SaveChanges();
                Session["cart"] = null; //xoa gio hang sau khi order
            }

            return Redirect("http://sandbox.vnpayment.vn/tryitnow/Home/CreateOrder");
        }
        public string CheckoutSuccess()
        {
            return "Create order successfully!";
        }
    }
}
