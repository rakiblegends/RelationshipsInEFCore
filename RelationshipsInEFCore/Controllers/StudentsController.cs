﻿using Microsoft.AspNetCore.Mvc;
using RelationshipsInEFCore.Models;
using RelationshipsInEFCore.Repository;

namespace RelationshipsInEFCore.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentRepository.GetAllAsync();
            return View(students);
        }

        public async Task<IActionResult> Details(int id)
        {
            var student = await _studentRepository.GetStudentDetailsByIdAsync(id);
            if (student == null)
            {
                return NotFound($"Student with {id} not found!");
            }
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _studentRepository.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound($"Student with {id} not found!");
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Student student)
        {
            
            if (ModelState.IsValid)
            {
                await _studentRepository.UpdateAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
