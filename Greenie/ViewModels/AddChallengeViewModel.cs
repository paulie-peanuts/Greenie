using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Greenie;

    public class AddChallengeViewModel
    {
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        public AddChallengeViewModel() { }
    }
