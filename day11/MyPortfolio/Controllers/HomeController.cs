using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.helper;
using MyPortfolio.Models;
using System.Diagnostics;
using System.Security.Cryptography; // ��ȣȭ 

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; 

        //public HomeController(ILogger<HomeController> logger, AppDbContext _context)
        //{
        //    _logger = logger;
        //    AppDbContext context; // DB�� �����ؼ� ����ϰڴٴ� �ʱ�ȭ ����
        //}

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] // ����Ʈ ���̶� �������������� ������ �ۼ� 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // ȸ���α������� ���� �߰� 
        [HttpGet] 
        public IActionResult Login()
        {
            return View();  
        }

        // �α���
        [HttpPost]
        public IActionResult Login(User user)
        {
            // userEmail, password md5�� ��ȣȭ 
            // DB�� �ִ� ���� �� 
            var mdhash = MD5.Create(); 
            user.Password = common.GetMd5Hash(mdhash, user.Password); // �α���â�� �Է��� ��ȣ�� ��ȣȭ 

            var result = _context.User.FirstOrDefault(u => u.UserEmail == user.UserEmail && u.Password == user.Password);
            
            if (result == null) // �α��� �� ����� ����
            {
                ViewBag.ErrorMessage = "��й�ȣ�� ��ġ���� �ʽ��ϴ�.";
                return View(user);
            }
            else
            {
                // �α��� ����ó��
                HttpContext.Session.SetInt32("USER_LOGIN_KEY", result.Id);
                HttpContext.Session.SetString("USER_NAME", result.UserName);
                HttpContext.Session.SetString("USER_EMAIL", result.UserEmail);

                return RedirectToAction("Index", "Home"); // �α��� �Ϸ� 
            }
        }

        // �α׾ƿ�
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            HttpContext.Session.Remove("USER_NAME");
            HttpContext.Session.Remove("USER_EMAIL");

            return RedirectToAction("Index", "Home");
        }

        // ȸ����� �������� ���� 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        // ȸ����� ������ ������ DB�� ���� 
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if(user.Password != user.PasswordCheck)
            {
                // �н����� �� ���� ��ġ���� ���� ��, �Ϻη� ���������� �߻���Ŵ 
                ModelState.AddModelError("passwordCheck", "�н����尡 ��ġ���� �ʽ��ϴ�.");
            }
            
            if (ModelState.IsValid)
            {
                user.RegDate = DateTime.Now; // ȸ�� ��� ��¥�� ���÷� ����

                var mdHash = MD5.Create();
                user.Password = common.GetMd5Hash(mdHash, user.Password);
                user.PasswordCheck = null;

                _context.Add(user); // Insert
                await _context.SaveChangesAsync();  // Commit 
                return RedirectToAction("Login");
            }
            return View(user);
        }
        

    }
}
