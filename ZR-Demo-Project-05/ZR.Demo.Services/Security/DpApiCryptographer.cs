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
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Demo.Services.Security
{
    public class DpApiCryptographer
    {
        private readonly IDataProtector _dataProtector;


        public string Encrypt(string text)
        {
            string? proteced = _dataProtector.Protect(text);

            return proteced;
        }
        public string Decrypt(string text)
        {
            string? proteced = _dataProtector.Unprotect(text);

            return proteced;
        }



    }
}
