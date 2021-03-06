﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforce.Models.ViewModels

{
    public class ComputerCreateViewModel

    {
        public int Id { get; set; }
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Decomission Date")]
        public DateTime? DecomissionDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        public List<SelectListItem> EmployeeOptions { get; set; }
        public Employee employee { get; set; }
    }

} 