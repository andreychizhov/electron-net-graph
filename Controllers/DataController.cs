using System.Collections.Generic;
using electron_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace electron_net.Controllers
{
    public class DataController : Controller
    {
        private readonly List<node> _nodes;
        private readonly List<edge> _edges;

        public DataController()
        {
            var lines = System.IO.File.ReadAllLines(@"d:\files\dependencies.txt");
            
            // 1 form nodes
            _nodes = lines.Select(n => n.Split(" <-- ")[0])
                .Concat(lines.Select(n => n.Split(" <-- ")[1]))
                .Distinct()
                .Select((s, i) => new node { id = i + 1, label = s}).ToList();

            // form helper map
            var map = _nodes.ToDictionary(k => k.label, v => v.id);
            
            // 2 form edges
            _edges = lines.Select(n => n.Split(" <-- "))
                .Select(n => new edge {from = map[n[1]], to = map[n[0]], arrows = "to"}).ToList();
        }
        
        [HttpGet]
        public IActionResult GetGraph()
        {
            return Json(new { nodes = _nodes, edges = _edges });
        }
    }
}