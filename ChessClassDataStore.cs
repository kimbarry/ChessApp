using ChessClubApi.Models;

namespace ChessClubApi
{
    public class ChessClassDataStore
    {
        public List<ChessClassDto> Classes { get; set; }
        public static ChessClassDataStore Current { get; } = new ChessClassDataStore();

        public ChessClassDataStore()
        {
            Classes = new List<ChessClassDto>
            {
                new ChessClassDto()
                {
                    Id = 1,
                    
                },

                new ChessClassDto()
                {
                    Id = 2,
                    

                },

                new ChessClassDto()
                {
                    Id = 3,  
                },

                new ChessClassDto()
                {
                    Id = 4,
                    
                    
                },
            };
        }
    }   
}
