using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoCMS_SubmissionTask.Models;
using UmbracoCMS_SubmissionTask.Services;

namespace UmbracoCMS_SubmissionTask.Controllers
{
    public class FormQuestionSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        [HttpPost]
        public async Task<IActionResult> HandleRequestQuestion(FormQuestionModel form)
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

            string subject = "New Question Submitted";
            string body = $"Hi {form.Name},\n\nThank you for your question: {form.Question}.\n\nWe will get back to you soon!";

            await MailgunService.SendEmailAsync(form.Email, subject, body);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public async Task<IActionResult> HandleRequestCallBack(FormCallbackModel form)
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

            string subject = "Your Callback Request has been received";
            string body = $"Hi {form.Name},\n\nWe have received your request for a callback regarding {form.Service}. We will contact you as soon as possible.\n\nBest regards,\nCompany Name";

            await MailgunService.SendEmailAsync(form.Email, subject, body);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        public async Task<IActionResult> HandleRequestHelp(FormHelpModel form)
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

            string subject = "Help Request Submitted";
            string body = $"Hi,\n\nYou have submitted a help request with the following details: \n\nEmail: {form.Email}";

            await MailgunService.SendEmailAsync(form.Email, subject, body);

            TempData["success"] = "form submitted successfully.";
            return RedirectToCurrentUmbracoPage();
        }
    }
}