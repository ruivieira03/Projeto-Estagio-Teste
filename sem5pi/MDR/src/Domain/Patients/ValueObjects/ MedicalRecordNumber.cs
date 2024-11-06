/*

using System;
using Hospital.Domain.Shared;
using Newtonsoft.Json;

namespace Hospital.Domain.Patients{
    public class MedicalRecordNumber : EntityId{
        [JsonConstructor]
        public PatientId(Guid value) : base(value){
        }

        public PatientId(String value) : base(value){
        }

        override
        protected  Object createFromString(String text){
            return new Guid(text);
        }

        override
        public String AsString(){
            Guid obj = (Guid) base.ObjValue;
            return obj.ToString();
        }
        
       
        public Guid AsGuid(){
            return (Guid) base.ObjValue;
        }
    }
}

*/