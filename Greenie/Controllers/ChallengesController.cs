using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Greenie;

[Route("/challenges")]
    public class ChallengesController : Controller
    {
        private readonly ChallengeDbContext context;
        public ChallengesController(ChallengeDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult RenderChallengesPage()
        {
            List<Challenge> challenges = context.Challenges.ToList();
            return View("Index", challenges);
        }

        [HttpGet("add")]
        public IActionResult RenderAddChallengeForm()
        {
            AddChallengeViewModel addChallengeViewModel = new();
            return View("Add", addChallengeViewModel);
        }

        [HttpPost("add")]
        public IActionResult ProcessAddChallengeForm(AddChallengeViewModel addChallengeViewModel)
        {
            if (ModelState.IsValid)
            {
                Challenge challenge = new()
                {
                    Title = addChallengeViewModel.Title
                };
                context.Challenges.Add(challenge);
                context.SaveChanges();
                return Redirect("/challenges");
            }
            return View("Add", addChallengeViewModel);
        }
    
    [HttpGet("delete")]
    public IActionResult RenderDeleteChallengeForm()
    {
        List<Challenge> challenges = context.Challenges.ToList();
        return View("Delete", challenges);
    }

    [HttpPost("delete")]
    public IActionResult ProcessDeleteChallengeForm(int[] challengeIds)
    {
        foreach (int id in challengeIds)
        {
            Challenge? theChallenge = context.Challenges.Find(id);
            if (theChallenge != null)
            {
                context.Challenges.Remove(theChallenge);
            }
        }
        context.SaveChanges();
        return Redirect("/challenges");
    }
    }
