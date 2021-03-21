using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Womens"))
                .ToList();

            ViewBag.HockeyLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
                
            ViewBag.OtherThanFootballLeagues = _context.Leagues
                .Where(l => !l.Sport.Contains("Football"))
                .ToList();

            ViewBag.ConferenceLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
            
            ViewBag.AtlanticLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();

            ViewBag.DallasTeams = _context.Teams
                .Where(t => t.Location.Contains("Dallas"))
                .ToList();
            
            ViewBag.RaptorsTeams = _context.Teams
                .Where(t => t.TeamName.Contains("Raptors"))
                .ToList();

            ViewBag.CityTeams = _context.Teams
                .Where(t => t.Location.Contains("City"))
                .ToList();

            ViewBag.TeamsBeginningWithT = _context.Teams
                .Where(t => t.TeamName.StartsWith("T"))
                .ToList();

            ViewBag.OrderedTeamsByLocation = _context.Teams
                .OrderBy(t => t.Location)
                .ToList();

            ViewBag.OrderedDescTeamsByTeamName = _context.Teams
                .OrderByDescending(t => t.TeamName)
                .ToList();

            ViewBag.PlayerLastNameCooper = _context.Players
                .Where(p => p.LastName.Equals("Cooper"))
                .ToList();

            ViewBag.PlayerFirstNameJoshua  = _context.Players
                .Where(p => p.FirstName.Equals("Joshua"))
                .ToList();
            
            ViewBag.PlayerLastNameCooperFirstNameNotJoshua = _context.Players
                .Where(p => p.LastName.Equals("Cooper") && !p.FirstName.Equals("Joshua"))
                .ToList();

            ViewBag.PlayerFirstNameAlexanderOrWyatt = _context.Players
                .Where(p => p.FirstName.Equals("Alexander") || p.FirstName.Equals("Wyatt"))
                .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            ViewBag.TeamsInAtlanticSoccerConference = _context.Teams
                .Include(team => team.CurrLeague)
                .Where(team => team.CurrLeague.Name.Equals("Atlantic Soccer Conference"))
                .ToList();

            ViewBag.CurrPlayersInBostonPenguins = _context.Players
                .Include(player => player.CurrentTeam)
                .Where(player => player.CurrentTeam.TeamName.Equals("Penguins") && player.CurrentTeam.Location.Equals("Boston"))
                .ToList();
            
            ViewBag.CurrPlayersInInternationalCollegiateBaseballConference = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.CurrentTeam.CurrLeague.Name.Equals("International Collegiate Baseball Conference"))
                .ToList();

            ViewBag.CurrPlayersInAmericanConferenceFootballLastNameLopez = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.LastName.Equals("Lopez") && player.CurrentTeam.CurrLeague.Name.Equals("American Conference of Amateur Football"))
                .ToList();
            
            ViewBag.AllFootballPlayers = _context.PlayerTeams
                .Include(player => player.PlayerOnTeam)
                .Include(player => player.TeamOfPlayer.CurrLeague)
                .Where(player => player.TeamOfPlayer.CurrLeague.Sport.Equals("Football"))
                .ToList();
            
            ViewBag.AllTeamsWithCurrentPlayerSophia = _context.Players
                .Include(player => player.CurrentTeam)
                .Where(player => player.FirstName.Equals("Sophia"))
                .ToList();

            ViewBag.AllLeaguesWithCurrentPlayerSophia = _context.Players
                .Include(player => player.CurrentTeam.CurrLeague)
                .Where(player => player.FirstName.Equals("Sophia"))
                .ToList();

            ViewBag.PlayerWithLastNameFloresDoesntCurrentlyPlayForWashingtonRoughriders = _context.Players
                .Include(player => player.CurrentTeam)
                .Where(player => !(player.CurrentTeam.TeamName.Equals("Roughriders") && player.CurrentTeam.Location.Equals("Washington")) 
                                && player.LastName.Equals("Flores"))
                .ToList();

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}