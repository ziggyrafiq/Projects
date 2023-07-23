/************************************************************************************************************
*  COPYRIGHT BY ZIGGY RAFIQ (ZAHEER RAFIQ)
*  LinkedIn Profile URL Address: https://www.linkedin.com/in/ziggyrafiq/ 
*
*  System   :  	ZR Demo Project 05
*  Date     :  	13/10/2022
*  Author   :  	Ziggy Rafiq (https://www.ziggyrafiq.com)
*  Notes    :  	
*  Reminder :	PLEASE DO NOT CHANGE OR REMOVE AUTHOR NAME.
*
************************************************************************************************************/
using Microsoft.AspNetCore.Mvc;

namespace ZR.Demo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultApiController : ControllerBase
    {
         

        private readonly ILogger<DefaultApiController> _logger;

        public DefaultApiController(ILogger<DefaultApiController> logger)
        {
            _logger = logger;
        }

        
    }
}