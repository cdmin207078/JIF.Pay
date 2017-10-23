﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JIF.Pay.Sample.API.Controllers
{
    public class BaseController : ApiController
    {
        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxOk()
        {
            return Ok(new
            {
                success = true
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult AjaxOk(string message)
        {
            return Ok(new
            {
                success = true,
                message = message
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxOk(int code, string message)
        {
            return Ok(new
            {
                success = true,
                code = code,
                message = message
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">返回数据</param>
        /// <returns></returns>
        public IHttpActionResult AjaxOk<T>(T data)
        {
            return Ok(new
            {
                success = true,
                data = data
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">返回数据</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxOk<T>(string message, T data)
        {
            return Ok(new
            {
                success = true,
                message = message,
                data = data,
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">返回数据</param>
        /// <param name="code">错误码</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxOk<T>(int code, string message, T data)
        {
            return Ok(new
            {
                success = true,
                code = code,
                message = message,
                data = data,
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult AjaxFail()
        {
            return Ok(new
            {
                success = false,
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxFail(string message)
        {
            return Ok(new
            {
                success = false,
                message = message
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxFail(int code, string message)
        {
            return Ok(new
            {
                success = false,
                code = code,
                message = message
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">返回数据</param>
        /// <returns></returns>
        public IHttpActionResult AjaxFail<T>(T data)
        {
            return Ok(new
            {
                success = false,
                data = data
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">返回数据</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxFail<T>(string message, T data)
        {
            return Ok(new
            {
                success = false,
                message = message,
                data = data,
            });
        }

        [NonAction]
        /// <summary>
        /// Ajax请求错误
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code">错误码</param>
        /// <param name="data">返回数据</param>
        /// <param name="message">附加消息</param>
        /// <returns></returns>
        public IHttpActionResult AjaxFail<T>(int code, string message, T data)
        {
            return Ok(new
            {
                success = false,
                code = code,
                message = message,
                data = data,
            });
        }
    }
}
