using System.ComponentModel.DataAnnotations;


namespace TimeManagement.Models{

    public class ActivityUnity {

        [Key]
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Infome a Sigla")]
        [MinLength(3,ErrorMessage = "Mínimo 3 caracteres para a sigla")]
        [MaxLength(5,ErrorMessage = "Máximo 5 caracteres para a sigla")]

        public string Acronym { get; set;} = string.Empty;



        [Required(ErrorMessage = "Infome a Título")]
        [MinLength(4,ErrorMessage = "Mínimo 4 caracteres para o Título")]
        [MaxLength(50,ErrorMessage = "Máximo 50 caracteres para o Título")]

        public string Title { get; set;} = string.Empty;


        
        [MaxLength(128 ,ErrorMessage = "Máximo 128 caracteres para a Descrição")]
        public string Description { get; set; } = string.Empty;



    
    


    }

}