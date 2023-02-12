﻿using Boss.az1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boss.az
{
    public class Employer : Human
    {
        public Employer(string username, string pass, string name, string surname, string city, string phone, int age)
            : base(name, surname, city, phone, age)
        {
            Username = username;
            Password = pass;
            Id = ++ID;
        }
        static int ID { get; set; } = 0;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
        public List<Worker> Workers { get; set; } = null;
        public static int Count { get; set; }
        public Notification Notifications { get; set; } = new Notification();
        public List<Worker> Applicant { get; set; } = new List<Worker>();
        public List<Vacancy> ApplicantVacancy { get; set; } = new List<Vacancy>();

        public new void Show()
        {
            Console.WriteLine($"Id : {Id}");
            base.Show();
        }

        public Vacancy GetVacancyById(int id)
        {
            foreach (var vacancy in Vacancies)
            {
                if (vacancy.Id == id)
                {
                    return vacancy;
                }
            }
            return null;
        }
    }
}
