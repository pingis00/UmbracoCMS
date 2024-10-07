using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoCMS_SubmissionTask.Models;

namespace UmbracoCMS_SubmissionTask.Controllers
{
    public class FormQuestionSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        [HttpPost]
        public IActionResult HandleRequestQuestion(FormQuestionModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["name"] = form.Name;
                ViewData["email"] = form.Email;
                ViewData["question"] = form.Question;

                ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
                ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
                ViewData["error_question"] = string.IsNullOrEmpty(form.Question);

                return CurrentUmbracoPage();
            }
            var contentService = Services.ContentService;
            var nodeGuid = new Guid("7f43740b-86ff-4f57-9354-9db28cc6394f");
            var nodeId = contentService!.GetById(nodeGuid);

            var question = contentService.Create(Guid.NewGuid().ToString(), nodeId, "questionItem");
            question.SetValue("author", form.Name);
            question.SetValue("email", form.Email);
            question.SetValue("question", form.Question);

            contentService.Save(question);
            contentService.Publish(question, []);

            SendconfirmationEmail(form.Email, form.Name);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public IActionResult HandleRequestCallBack(FormCallbackModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["name"] = form.Name;
                ViewData["email"] = form.Email;
                ViewData["phone"] = form.Phone;

                ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
                ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
                ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);

                return CurrentUmbracoPage();
            }

            var contentService = Services.ContentService;
            var nodeGuid = new Guid("651e7d48-d381-46bc-8577-f631288e16c4");
            var nodeId = contentService!.GetById(nodeGuid);

            var question = contentService.Create(Guid.NewGuid().ToString(), nodeId, "callbackItem");
            question.SetValue("author", form.Name);
            question.SetValue("email", form.Email);
            question.SetValue("phone", form.Phone);
            question.SetValue("service", form.Service);

            contentService.Save(question);
            contentService.Publish(question, []);

            SendconfirmationEmail(form.Email, form.Name);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public IActionResult HandleRequestHelp(FormHelpModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["email"] = form.Email;

                ViewData["error_email"] = string.IsNullOrEmpty(form.Email);

                return CurrentUmbracoPage();
            }

            var contentService = Services.ContentService;
            var nodeGuid = new Guid("9d73645e-d923-45c8-93ce-a7e8725401ea");
            var nodeId = contentService!.GetById(nodeGuid);

            var question = contentService.Create(Guid.NewGuid().ToString(), nodeId, "helpItem");
            question.SetValue("email", form.Email);

            contentService.Save(question);
            contentService.Publish(question, []);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }


        private void SendconfirmationEmail(string toEmail, string name)
        {
            var fromAddress = "testingUmbracoCms@gmail.com";
            var fromPassword = "UmbracoCms11!";

            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(fromAddress);
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = "Confirmation";
            mailMessage.Body = $"Hi {name}, Thank you for your question! We will awnser as soon as possible";

            using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to send email: " + ex.Message);
                }
            }
        }
    }
}