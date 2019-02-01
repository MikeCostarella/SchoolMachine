﻿using SchoolMachine.DataAccess.Entities.ExtendedModels;
using SchoolMachine.DataAccess.Entities.Models;
using System;
using System.Collections.Generic;

namespace SchoolMachine.Contracts.EntityRepositories
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudentById(Guid studentId);

        StudentExtended GetStudentWithDetails(Guid studentId);
    }
}
