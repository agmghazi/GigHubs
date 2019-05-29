using GigHub.Controllers;
using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public string Heading { get; set; }
        public DateTime GetDateTime() => DateTime.Parse($"{Date} {Time}");

        public string Action
        {
            get
            {
                Expression<Func<GigsController, ActionResult>> Create =
                     (c => c.Create());

                Expression<Func<GigsController, ActionResult>> Update =
                      (u => u.Update(this));

                var action = (Id != 0) ? Update : Create;
                return (action.Body as MethodCallExpression).Method.Name;
            }
        }
    }


}
