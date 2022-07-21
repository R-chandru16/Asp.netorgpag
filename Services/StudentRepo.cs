
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_student.Services;
using Asp.net_student.Models;

namespace Asp.net_student.Services
{
    public class StudentRepo : IRepo<Student>
    {
        private readonly CollegeContext _context;
        public StudentRepo(CollegeContext context)
        {
            _context = context;
        }
        public Student Add(Student k)
        {
            try
            {
                _context.Students.Add(k);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

      

        public Student Delete(int id)
        {

            //FirstorDefault->Returns the first element of a collection, or the first element that satisfies a condition.
            //or Returns a default value if index is out of range.
            Student stud = null;
            try
            {
                stud = _context.Students.FirstOrDefault(e => e.Id == id);
                _context.Students.Remove(stud);
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return stud;
        }


        public Student Get(int id)
        {
            Student stud = null;
            try
            {
                stud = _context.Students.FirstOrDefault(e => e.Id == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return stud;
        }


        public ICollection<Student> GetAll()
        {
            IList<Student> stud = _context.Students.ToList();
            if (stud.Count > 0)
                return stud;
            else
                return null;
        }


        public Student Update(Student k)
        {
            Student stud = null;
            try
            {
                stud = _context.Students.FirstOrDefault(e => e.Id == k.Id);
                stud.Name = k.Name;
                stud.Age = k.Age;
                stud.DepartmentId = k.DepartmentId;
                stud.Phone = k.Phone;
                stud.Gender = k.Gender;
                stud.Email = k.Email;
                stud.country = k.country;
                stud.EnrollmentDate = k.EnrollmentDate;
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return stud;
        }

       
    }
}


