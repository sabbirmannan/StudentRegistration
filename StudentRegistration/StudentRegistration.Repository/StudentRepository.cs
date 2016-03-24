﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistration.Model;

namespace StudentRegistration.Repository
{
    public class StudentRepository : BaseRepository
    {
        public StudentRepository(BusinessDbContext db) : base(db)
        {
            
        }

        public IQueryable<Student> GetAll()
        {
            return Db.Students.AsQueryable();
        }

        public string Add(Student student)
        {
            Student added = Db.Students.Add(student);
            Db.SaveChanges();
            return added.Id;
        }

        public bool Exists(string id)
        {
            return Db.Students.Any(x => x.Id == id);
        }
    }
}
