
using Asp.net_student.Models;
using Asp.net_student.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Asp.net_student.Controllers
{

    public class StudentsController : Controller
    {
        private readonly IRepo<Student> _repo;


        public StudentsController(IRepo<Student> repo)
        {
            _repo = repo;
        }

        public IActionResult Index( int ? page)
        {
            var students = _repo.GetAll();
            return View(students.ToPagedList(page ?? 1, 5));

           // return View(_repo.GetAll());
            //IEnumerable<Student> obj = (_repo.GetAll());
            //return View(obj); 
        }
        public IActionResult Details(int id)
        {
            return View(_repo.Get(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student employee)
        {
            _repo.Add(employee);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Student employee)
        {
            _repo.Update(employee);
            return RedirectToAction("Index");

        }

        //public IActionResult Delete(int id)
        //{
        //    _repo.Delete(id);
        //    return RedirectToAction("Index");
        //}
        public IActionResult Delete(int id)
        {
            return View(_repo.Delete(id));
        }

    }
}
   


 
    



