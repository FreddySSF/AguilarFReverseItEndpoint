// Fernando Aguilar
// 10-27-22
// Reverse It Endpoint
// We take the mini challenge 7 and convert it into an API program.
// The user inputs a number and the output on Postman reverses the number given.
// Peer Reviewed By: Rafael Manzo, Ran program and it runs as intended, Code looks interesting will have too take a closer look in gitHub when i hv more time


using Microsoft.AspNetCore.Mvc;

namespace AguilarFReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("reverseIt/{num}")]

    public int reverseNumber(string num)
    {
        bool isNumber;
        int x = 0;
        int y = 0;
        int z = 0;
        isNumber = Int32.TryParse(num, out x);


        while (x != 0)
        {

            z = x % 10;
            y = y * 10 + z;
            x /= 10;

        }
        return y;
    }

}