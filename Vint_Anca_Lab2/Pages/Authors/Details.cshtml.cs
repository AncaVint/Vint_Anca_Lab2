﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vint_Anca_Lab2.Data;
using Vint_Anca_Lab2.Models;

namespace Vint_Anca_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Vint_Anca_Lab2.Data.Vint_Anca_Lab2Context _context;

        public DetailsModel(Vint_Anca_Lab2.Data.Vint_Anca_Lab2Context context)
        {
            _context = context;
        }

      public Author Authors { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else 
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
