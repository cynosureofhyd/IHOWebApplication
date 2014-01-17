using IHOWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IHOWebApplication.ControllersApi
{
    public class FieldNotesController : ApiController
    {
        public IEnumerable<FieldNotes> Get()
        {
            IHODbEntities db = new IHODbEntities();
            FieldNote firstFieldNote = new FieldNote();
            List<FieldNote> dbFieldNotes = db.FieldNotes.ToList();
            List<FieldNotes> fieldNotes = new List<FieldNotes>();
            foreach(var fieldNote in dbFieldNotes)
            {
                fieldNotes.Add(new FieldNotes()
                    {
                        Bio = fieldNote.Bio,
                        ImageSrc = fieldNote.ImageSrc,
                        MailAddress = fieldNote.MailAddress,
                        ProfessorName = fieldNote.ProfessorName
                    });
            }
            return fieldNotes;

            //return new List<FieldNotes>();
        }
    }
}

