﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMediatorHandler _bus;
        private ICourseRepository _courseRepo;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepo = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );
            _bus.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepo.GetCourses()
            };
        }
    }
}
