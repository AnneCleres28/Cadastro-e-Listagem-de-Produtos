using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CadastroEListagemDeProdutos.Core.DataBase;
using CadastroEListagemDeProdutos.Models;

namespace CadastroEListagemDeProdutos.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly CadastroEListagemDeProdutos.Core.DataBase.DataBase _context;

        public DetailsModel(CadastroEListagemDeProdutos.Core.DataBase.DataBase context)
        {
            _context = context;
        }

      public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            else 
            {
                Produto = produto;
            }
            return Page();
        }
    }
}
