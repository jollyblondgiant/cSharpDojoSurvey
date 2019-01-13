using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class SurveyForm
    {
        [Required(ErrorMessage="What's yer name, hun?")]
        [MinLength(4, ErrorMessage="Yer REAL name!")]
        [Display(Name="Name: ")]
        public string UserName{get;set;}

        [Required(ErrorMessage = "Where are ya?")]
        [MinLength(1, ErrorMessage="Pick one, dummy!")]
        [Display(Name="Location:")]
        public string Location{get;set;}

        [Required(ErrorMessage = "Everybody's gotta say somethin'")]
        [MinLength(1, ErrorMessage="Pick one, dummy!")]
        [Display(Name="Language:")]
        public string Language {get;set;}

        [Display(Name="Comment (optional): ")]
        public string Comment {get;set;}
    }
}