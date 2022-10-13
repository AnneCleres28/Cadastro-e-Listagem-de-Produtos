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
    public class IndexModel : PageModel
    {
        private readonly CadastroEListagemDeProdutos.Core.DataBase.DataBase _context;

        public IndexModel(CadastroEListagemDeProdutos.Core.DataBase.DataBase context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produtos != null)
            {
                Produto = await _context.Produtos.OrderBy(a => a.Valor).ToListAsync();
            }
        }
    }
}
