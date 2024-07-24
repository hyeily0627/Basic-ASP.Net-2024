using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;

namespace MyPortfolio.Controllers
{
    // 어노테이션
    [Route("api/[controller]")] // api/BoardRest로 URL을 만들어줌 
    [ApiController]
    public class BoardRestController : Controller
    {
        private readonly AppDbContext _context; // DB 사용 가능 

        // ctrl + alt 해서 생성자 추가 
        public BoardRestController(AppDbContext context)
        {
            _context = context;
        }

        //[HttpGet] // 화면 요청
        //[HttpPost] // 값을 저장할 때 
        //[HttpPut] // 값을 수정할 때
        [HttpDelete("{id}")] // 값을 삭제할 때
        public async Task<IActionResult> DeleteBoard(int id)
        {
            var Board = await _context.Board.FindAsync(id); // Select * where id = id
            if (Board == null)
            {
                return NotFound(); // 404 Error
            }

            _context.Board.Remove(Board);  // Asp.net 상 메모리에 들어있는 DB 객체 데이터 삭제
            await _context.SaveChangesAsync();  // DB가 삭제되고 commit

            return NoContent(); // 아무 데이터도 없음을 리턴
        }
    }
}