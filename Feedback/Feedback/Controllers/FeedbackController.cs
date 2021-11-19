using Dapper;
using Feedback.CustomModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Data;

namespace Feedback.Controllers
{
    public class FeedbackController : Controller
    {

        private string _connectionString = "data source=TRAINEE-03;initial catalog = FeedbackAssignment; Trusted_Connection = false;user id = sa; password=@9543890461My;MultipleActiveResultSets=True;";


        //get satisfaction
        public ActionResult GetSatisfactory()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    IEnumerable<Satisfactory> satisfactories = sqlConnection.Query<Satisfactory>("ProcSatisfactory", commandType: CommandType.StoredProcedure).ToList();
                    return Json(satisfactories, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get country
        public ActionResult GetCountry()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    IEnumerable<Country> countries = sqlConnection.Query<Country>("ProcCountry", commandType: CommandType.StoredProcedure).ToList();
                    return Json(countries, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get category
        public ActionResult GetCategory()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    IEnumerable<Category> categories = sqlConnection.Query<Category>("ProcCategory", commandType: CommandType.StoredProcedure).ToList();
                    return Json(categories, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //get product
        public ActionResult GetProduct()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    IEnumerable<Product> products = sqlConnection.Query<Product>("ProcProduct", commandType: CommandType.StoredProcedure);
                    return Json(products, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get title
        public ActionResult GetTitle()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    IEnumerable<Title> titles = sqlConnection.Query<Title>("ProcTitle", commandType: CommandType.StoredProcedure);
                    return Json(titles, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: Feedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Feedback/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Feedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Feedback/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
