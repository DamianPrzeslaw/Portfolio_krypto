using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio_Krypto.Data;
using Portfolio_Krypto.Models;

namespace Portfolio_Krypto.Controllers
{
    public class TokensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TokensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tokens
        public async Task<IActionResult> Index()
        {

            List<TokenExpanded> lista = new List<TokenExpanded>();
            TokenName temp1 = new TokenName();
            //   listatoken = await _context.Token.ToListAsync();
          var  listatoken = from token in _context.Token where token.userName == User.Identity.Name select token;
            foreach (var item in listatoken)
            {
                TokenExpanded temp = new TokenExpanded(item);
                try
                {
                    await temp.update();
                }
                catch(Exception e)
                {
                    ;
                }
                lista.Add(temp);
            }

            return View(lista);
        }

        // GET: Tokens/Details/5
        public async Task<IActionResult> Details(string? name)
        {
            if (name == null)
            {
                return NotFound();
            }

            //var token = await  _context.Token
            //    .FirstOrDefaultAsync(m => m.tokenName == name);
            List<TokenExpanded> lista = new List<TokenExpanded>();
            var listatokenow = from token in _context.Token where token.tokenName == name && token.userName == User.Identity.Name select token;
            foreach (var item in listatokenow)
            {
                TokenExpanded tokenExpanded = new TokenExpanded(item);
                await tokenExpanded.update();
                lista.Add(tokenExpanded);
            }
         
            if (lista == null)
            {
                return NotFound();
            }

            return View(lista);
        }

        public async Task< IActionResult> token_name()
        {
            List<TokenName> asd = new List<TokenName>();
            asd = await _context.TokenName.ToListAsync(); ;
            return View(asd);
        }
        // GET: Tokens/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Tokens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,userName,tokenName,price_buy,amount,date_buy,id_geco")] Token token)
        {
            if (ModelState.IsValid)
            {
                token.userName = User.Identity.Name;
                var idss = from tokenname in _context.TokenName where tokenname.name == token.tokenName select tokenname.id;
                token.id_geco = idss.First();

                _context.Add(token);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(token);
        }


        // GET: Tokens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var token = await _context.Token.FindAsync(id);
            if (token == null)
            {
                return NotFound();
            }
            return View(token);
        }

        // POST: Tokens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,userName,smartContract,tokenName,price_buy,amount,date_buy")] Token token)
        {
            if (id != token.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(token);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TokenExists(token.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(token);
        }

        // GET: Tokens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var token = await _context.Token
                .FirstOrDefaultAsync(m => m.id == id);
            if (token == null)
            {
                return NotFound();
            }

            return View(token);
        }

        // POST: Tokens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var token = await _context.Token.FindAsync(id);
            _context.Token.Remove(token);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TokenExists(int id)
        {
            return _context.Token.Any(e => e.id == id);
        }
    }
}
