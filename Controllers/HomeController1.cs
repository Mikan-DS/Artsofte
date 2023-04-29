using Microsoft.AspNetCore.Mvc;

namespace Artsofte.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: Employee/Add
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            try
            {
                // TODO: Добавить логику добавления сотрудника

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Добавить логику редактирования сотрудника

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Добавить логику удаления сотрудника

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
