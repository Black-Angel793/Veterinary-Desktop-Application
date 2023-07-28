using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.ML
{
    class CRUD
    {
        //Owner CRUD
        public void insert_owner(string fn, string ln, string gender, int ph, string ad)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@fn", SqlDbType.VarChar, 50);
            param[0].Value = fn;
            param[1] = new SqlParameter("@ln", SqlDbType.VarChar, 50);
            param[1].Value = ln;
            param[2] = new SqlParameter("@gen", SqlDbType.VarChar, 20);
            param[2].Value = gender;
            param[3] = new SqlParameter("@p", SqlDbType.Int);
            param[3].Value = ph;
            param[4] = new SqlParameter("@Ad", SqlDbType.VarChar, 50);
            param[4].Value = ad;
            insert.open();
            insert.execop("insert_owner", param);
            insert.close();
        }
        public void update_owner(int id, string fn, string ln, string gender,int ph, string ad)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@fn", SqlDbType.VarChar, 50);
            param[1].Value = fn;
            param[2] = new SqlParameter("@ln", SqlDbType.VarChar, 50);
            param[2].Value = ln;
            param[3] = new SqlParameter("@gen", SqlDbType.VarChar, 20);
            param[3].Value = gender;
            param[4] = new SqlParameter("@p", SqlDbType.Int);
            param[4].Value = ph;
            param[5] = new SqlParameter("@Ad", SqlDbType.VarChar, 50);
            param[5].Value = ad;
            update.open();
            update.execop("update_owner", param);
            update.close();
        }
        public void delete_owner(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_owner", p);
            delete.close();
        }
        public DataTable list_owner()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_owner");
            list_owner.close();
            return d;
        }
        public DataTable search_owner(string FN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@fn", SqlDbType.VarChar, 50);
            p[0].Value = FN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_owner", p);
            return dt;
        }
        public DataTable OwnersName()
        {
            DAL.DAL ownern = new DAL.DAL();
            DataTable d = new DataTable();
            ownern.open();
            d = ownern.read_data1("owner_name");
            ownern.close();
            return d;
        }

        //Animal CRUD 
        public void insert_animal(string AN, string Species, string breed, DateTime BD,string gender, string color, float weight, string MC, string VS, string picture, int owner)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = AN;
            param[1] = new SqlParameter("@sp", SqlDbType.VarChar, 50);
            param[1].Value = Species;
            param[2] = new SqlParameter("@br", SqlDbType.VarChar, 50);
            param[2].Value = breed;
            param[3] = new SqlParameter("@bd", SqlDbType.DateTime);
            param[3].Value = BD;
            param[4] = new SqlParameter("@gen", SqlDbType.VarChar, 20);
            param[4].Value = gender;
            param[5] = new SqlParameter("@co", SqlDbType.VarChar, 20);
            param[5].Value = color;
            param[6] = new SqlParameter("@we", SqlDbType.Float);
            param[6].Value = weight;
            param[7] = new SqlParameter("@mc", SqlDbType.VarChar, 100);
            param[7].Value = MC;
            param[8] = new SqlParameter("@vac", SqlDbType.VarChar, 100);
            param[8].Value = VS;
            param[9] = new SqlParameter("@image", SqlDbType.VarChar, 1000);
            param[9].Value = picture;
            param[10] = new SqlParameter("@owner", SqlDbType.Int);
            param[10].Value = owner;
            insert.open();
            insert.execop("insert_Animal", param);
            insert.close();
        }
        public void update_animal(int id, string AN, string Species, string breed, DateTime BD,string gender, string color, float weight, string MC, string VS, string picture, int owner)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[1].Value = AN;
            param[2] = new SqlParameter("@sp", SqlDbType.VarChar, 50);
            param[2].Value = Species;
            param[3] = new SqlParameter("@br", SqlDbType.VarChar, 50);
            param[3].Value = breed;
            param[4] = new SqlParameter("@bd", SqlDbType.DateTime);
            param[4].Value = BD;
            param[5] = new SqlParameter("@gen", SqlDbType.VarChar, 20);
            param[5].Value = gender;
            param[6] = new SqlParameter("@co", SqlDbType.VarChar, 20);
            param[6].Value = color;
            param[7] = new SqlParameter("@we", SqlDbType.Float);
            param[7].Value = weight;
            param[8] = new SqlParameter("@mc", SqlDbType.VarChar, 100);
            param[8].Value = MC;
            param[9] = new SqlParameter("@vac", SqlDbType.VarChar, 100);
            param[9].Value = VS;
            param[10] = new SqlParameter("@image", SqlDbType.VarChar, 1000);
            param[10].Value = picture;
            param[11] = new SqlParameter("@owner", SqlDbType.Int);
            param[11].Value = owner;
            update.open();
            update.execop("update_animal", param);
            update.close();
        }
        public void delete_animal(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_animal", p);
            delete.close();
        }
        public DataTable list_animals()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_animal");
            list_owner.close();
            return d;
        }
        public DataTable search_animal(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_animal", p);
            return dt;
        }

        //Consultation CRUD
        public void insert_consultation(string dc, string di,float price,int animal, int contype)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@dc", SqlDbType.DateTime);
            param[0].Value = dc;
            param[1] = new SqlParameter("@di", SqlDbType.VarChar, 1000);
            param[1].Value = di;
            param[2] = new SqlParameter("@price", SqlDbType.VarChar, 1000);
            param[2].Value = price;
            param[3] = new SqlParameter("@animal", SqlDbType.Int);
            param[3].Value = animal;
            param[4] = new SqlParameter("@cot", SqlDbType.Int);
            param[4].Value = contype;
            insert.open();
            insert.execop("insert_consultation", param);
            insert.close();
        }
        public void update_consultation(int id, string dc, string di,float price,int animal, int contype)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@dc", SqlDbType.DateTime);
            param[1].Value = dc;
            param[2] = new SqlParameter("@di", SqlDbType.VarChar, 1000);
            param[2].Value = di;
            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 1000);
            param[3].Value = price;
            param[4] = new SqlParameter("@animal", SqlDbType.Int);
            param[4].Value = animal;
            param[5] = new SqlParameter("@cot", SqlDbType.Int);
            param[5].Value = contype;
            update.open();
            update.execop("update_consultation", param);
            update.close();
        }
        public void delete_consultation(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_consultation", p);
            delete.close();
        }
        public DataTable list_consultations()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_consultation");
            list_owner.close();
            return d;
        }
        public DataTable search_consultation(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_consultation", p);
            return dt;
        }

        //Consultation Type CRUD
        public void insert_consultationType(string TN)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@namet", SqlDbType.VarChar, 50);
            param[0].Value = TN;
            insert.open();
            insert.execop("insert_consultType", param);
            insert.close();
        }
        public void update_consultationType(int id, string TN)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@namet", SqlDbType.VarChar, 50);
            param[1].Value = TN;
            update.open();
            update.execop("update_consultType", param);
            update.close();
        }
        public void delete_consultType(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_consultType", p);
            delete.close();
        }
        public DataTable list_consultType()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_consultType");
            list_owner.close();
            return d;
        }

        //Surgery CRUD
        public void insert_surgery(string ds, string procse, string at, string notes, int cons)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ds", SqlDbType.DateTime);
            param[0].Value = ds;
            param[1] = new SqlParameter("@procse", SqlDbType.VarChar, 1000);
            param[1].Value = procse;
            param[2] = new SqlParameter("@at", SqlDbType.VarChar, 100);
            param[2].Value = at;
            param[3] = new SqlParameter("@notes", SqlDbType.VarChar, 100);
            param[3].Value = notes;
            param[4] = new SqlParameter("@cons", SqlDbType.Int);
            param[4].Value = cons;
            insert.open();
            insert.execop("insert_surgery", param);
            insert.close();
        }
        public void update_surgery(int id, string ds, string procse, string at, string notes, int cons)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@ds", SqlDbType.DateTime);
            param[1].Value = ds;
            param[2] = new SqlParameter("@procse", SqlDbType.VarChar, 1000);
            param[2].Value = procse;
            param[3] = new SqlParameter("@at", SqlDbType.VarChar, 100);
            param[3].Value = at;
            param[4] = new SqlParameter("@notes", SqlDbType.VarChar, 100);
            param[4].Value = notes;
            param[5] = new SqlParameter("@cons", SqlDbType.Int);
            param[5].Value = cons;
            update.open();
            update.execop("update_surgery", param);
            update.close();
        }
        public void delete_surgery(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_surgery", p);
            delete.close();
        }
        public DataTable list_surgeries()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_surgery");
            list_owner.close();
            return d;
        }
        public DataTable search_surgery(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_surgery", p);
            return dt;
        }

        //Treatment CRUD
        public void insert_treatment(string sd, string ed, string inst, string notes, int cons)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@sd", SqlDbType.DateTime);
            param[0].Value = sd;
            param[1] = new SqlParameter("@ed", SqlDbType.Time);
            param[1].Value = ed;
            param[2] = new SqlParameter("@inst", SqlDbType.VarChar, 1000);
            param[2].Value = inst;
            param[3] = new SqlParameter("@notes", SqlDbType.VarChar, 100);
            param[3].Value = notes;
            param[4] = new SqlParameter("@cons", SqlDbType.Int);
            param[4].Value = cons;
            insert.open();
            insert.execop("insert_treatment", param);
            insert.close();
        }
        public void update_treatment(int id, string sd, string ed, string inst, string notes, int cons)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@sd", SqlDbType.DateTime);
            param[1].Value = sd;
            param[2] = new SqlParameter("@ed", SqlDbType.Time);
            param[2].Value = ed;
            param[3] = new SqlParameter("@inst", SqlDbType.VarChar, 1000);
            param[3].Value = inst;
            param[4] = new SqlParameter("@notes", SqlDbType.VarChar, 100);
            param[4].Value = notes;
            param[5] = new SqlParameter("@cons", SqlDbType.Int);
            param[5].Value = cons;
            update.open();
            update.execop("update_treatment", param);
            update.close();
        }
        public void delete_treatment(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_treatment", p);
            delete.close();
        }
        public DataTable list_treatments()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_treatment");
            list_owner.close();
            return d;
        }
        public DataTable search_treatment(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_treatment", p);
            return dt;
        }

        //Medication CRUD
        public void insert_medication(string n, string des, string df)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@n", SqlDbType.VarChar, 50);
            param[0].Value = n;
            param[1] = new SqlParameter("@des", SqlDbType.VarChar, 50);
            param[1].Value = des;
            param[2] = new SqlParameter("@df", SqlDbType.VarChar, 50);
            param[2].Value = df;

            insert.open();
            insert.execop("insert_medication", param);
            insert.close();
        }
        public void update_medication(int id, string n, string des, string df)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@n", SqlDbType.VarChar, 50);
            param[1].Value = n;
            param[2] = new SqlParameter("@des", SqlDbType.VarChar, 50);
            param[2].Value = des;
            param[3] = new SqlParameter("@df", SqlDbType.VarChar, 50);
            param[3].Value = df;
            update.open();
            update.execop("update_medication", param);
            update.close();
        }
        public void delete_medication(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_medication", p);
            delete.close();
        }
        public DataTable list_medications()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_medication");
            list_owner.close();
            return d;
        }
        public DataTable search_medication(string MN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = MN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_medication", p);
            return dt;
        }
        public DataTable GetMedByID(string id)
        {
            DAL.DAL srch = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            DataTable dt = new DataTable();
            dt = srch.read_data("getmedbyid", p);
            return dt;
        }

        //Medication Treatment CRUD
        public void insert_medictreatment(int idt, string idm)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TreatmentId", SqlDbType.Int);
            param[0].Value = idt;
            param[1] = new SqlParameter("@MedicationIds", SqlDbType.VarChar,50);
            param[1].Value = idm;
            insert.open();
            insert.execop("insert_medicationtreatment", param);
            insert.close();
        }
        public void update_medictreatment(int idt, string idm)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TreatmentId", SqlDbType.Int);
            param[0].Value = idt;
            param[1] = new SqlParameter("@MedicationIds", SqlDbType.VarChar, 50);
            param[1].Value = idm;
            update.open();
            update.execop("update_medicationtreatment", param);
            update.close();
        }
        public void delete_medictreatment(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_medicationtreatment", p);
            delete.close();
        }
        public DataTable list_medictreatment()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_medicationtreatment");
            list_owner.close();
            return d;
        }
        public DataTable GetMedDetails(int id)
        {
            DAL.DAL select = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            DataTable dt = new DataTable();
            dt = select.read_data("GetMedDetails", p);
            return dt;
        }

        //Appointment CRUD
        public void insert_appointment(string date, string r,int idc)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;
            param[1] = new SqlParameter("@r", SqlDbType.VarChar, 50);
            param[1].Value = r;
            param[2] = new SqlParameter("@idc", SqlDbType.Int);
            param[2].Value = idc;
            insert.open();
            insert.execop("insert_appointment", param);
            insert.close();
        }
        public void update_appointment(int id, string date, string r,int idc)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@r", SqlDbType.VarChar, 50);
            param[2].Value = r;
            param[3] = new SqlParameter("@idc", SqlDbType.Int);
            param[3].Value = idc;
            update.open();
            update.execop("update_appointment", param);
            update.close();
        }
        public void delete_appointment(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_appointment", p);
            delete.close();
        }
        public DataTable list_appointments()
        {
            DAL.DAL list_owner = new DAL.DAL();
            DataTable d = new DataTable();
            list_owner.open();
            d = list_owner.read_data1("read_appointment");
            list_owner.close();
            return d;
        }
        public DataTable search_appointment(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_treatment", p);
            return dt;
        }
        public DataTable eventday()
        {
            DAL.DAL eventd = new DAL.DAL();
            DataTable d = new DataTable();
            eventd.open();
            d = eventd.read_data1("eventday");
            eventd.close();
            return d;
        }

        //Payment CRUD
        public void insert_payment(float amount, int idc)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@pa", SqlDbType.Float);
            param[0].Value = amount;
            param[1] = new SqlParameter("@idc", SqlDbType.Int);
            param[1].Value = idc;
            insert.open();
            insert.execop("insert_payment", param);
            insert.close();
        }
        public void update_payment(int idp, float amount, int idc)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idp", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@pa", SqlDbType.Float);
            param[1].Value = amount;
            param[2] = new SqlParameter("@idc", SqlDbType.Int);
            param[2].Value = idc;
            update.open();
            update.execop("update_payment", param);
            update.close();
        }
        public void delete_payment(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_payment", p);
            delete.close();
        }
        public DataTable list_payment()
        {
            DAL.DAL lst_payment = new DAL.DAL();
            DataTable d = new DataTable();
            lst_payment.open();
            d = lst_payment.read_data1("read_payment");
            lst_payment.close();
            return d;
        }
        public DataTable GetTempTableMessages()
        {
            DAL.DAL message = new DAL.DAL();
            DataTable d = new DataTable();
            message.open();
            d = message.read_data1("GetMessage");
            message.close();
            return d;
        }

        //Store CRUD
        public void insert_product(string pn,int qts,float price)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@pn", SqlDbType.VarChar , 50);
            param[0].Value = pn;
            param[1] = new SqlParameter("@qts", SqlDbType.Int);
            param[1].Value = qts;
            param[2] = new SqlParameter("@price", SqlDbType.Float);
            param[2].Value = price;
            insert.open();
            insert.execop("insert_product", param);
            insert.close();
        }
        public void update_product(int idp, string pn, int qts, float price)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@idp", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@pn", SqlDbType.VarChar,50);
            param[1].Value = pn;
            param[2] = new SqlParameter("@qts", SqlDbType.Int);
            param[2].Value = qts;
            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;
            update.open();
            update.execop("update_product", param);
            update.close();
        }
        public void delete_product(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_product", p);
            delete.close();
        }
        public DataTable list_products()
        {
            DAL.DAL lst_product = new DAL.DAL();
            DataTable d = new DataTable();
            lst_product.open();
            d = lst_product.read_data1("read_product");
            lst_product.close();
            return d;
        }
        public DataTable search_product(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_product", p);
            return dt;
        }
        public DataTable productname()
        {
            DAL.DAL proname = new DAL.DAL();
            DataTable d = new DataTable();
            proname.open();
            d = proname.read_data1("productname");
            proname.close();
            return d;
        }
        public DataTable GetProductByID(string id)
        {
            DAL.DAL srch = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            DataTable dt = new DataTable();
            dt = srch.read_data("getproductbyid", p);
            return dt;
        }


        //Order CRUD
        public void insert_order(int ido, string products, string qt,string cost)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@OwnerID", SqlDbType.Int);
            param[0].Value = ido;
            param[1] = new SqlParameter("@ProductIds", SqlDbType.VarChar, 50);
            param[1].Value = products;
            param[2] = new SqlParameter("@Quantities", SqlDbType.VarChar, 50);
            param[2].Value = qt;
            param[3] = new SqlParameter("@Costs", SqlDbType.VarChar,50);
            param[3].Value = cost;
            insert.open();
            insert.execop("InsertOrder", param);
            insert.close();
        }
        public void update_order(int ido, string products, string qt, string cost)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@OrderId", SqlDbType.Int);
            param[0].Value = ido;
            param[1] = new SqlParameter("@ProductIds", SqlDbType.VarChar, 50);
            param[1].Value = products;
            param[2] = new SqlParameter("@Quantities", SqlDbType.VarChar, 50);
            param[2].Value = qt;
            param[3] = new SqlParameter("@Costs", SqlDbType.VarChar, 50);
            param[3].Value = cost;
            update.open();
            update.execop("UpdateOrder", param);
            update.close();
        }
        public void delete_order(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("DeleteOrder", p);
            delete.close();
        }
        public DataTable list_orders()
        {
            DAL.DAL lst_purchase = new DAL.DAL();
            DataTable d = new DataTable();
            lst_purchase.open();
            d = lst_purchase.read_data1("ListOrders");
            lst_purchase.close();
            return d;
        }
        public DataTable GetOrderDetails(int id)
        {
            DAL.DAL select = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            DataTable dt = new DataTable();
            dt = select.read_data("GetOrderDetails", p);
            return dt;
        }

        //Pens CRUD
        public void insert_pens(int dur, string sd, string ed,float priced,int animal)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@dur", SqlDbType.Int);
            param[0].Value = dur;
            param[1] = new SqlParameter("@sd", SqlDbType.DateTime);
            param[1].Value = sd;
            param[2] = new SqlParameter("@ed", SqlDbType.DateTime);
            param[2].Value = ed;
            param[3] = new SqlParameter("@priced", SqlDbType.Float);
            param[3].Value = priced;
            param[4] = new SqlParameter("@ida", SqlDbType.Int);
            param[4].Value = animal;
            insert.open();
            insert.execop("insert_pens", param);
            insert.close();
        }
        public void update_pens(int idp, int dur, string sd, string ed, float priced, int animal)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@idp", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@dur", SqlDbType.Int);
            param[1].Value = dur;
            param[2] = new SqlParameter("@sd", SqlDbType.DateTime);
            param[2].Value = sd;
            param[3] = new SqlParameter("@ed", SqlDbType.DateTime);
            param[3].Value = ed;
            param[4] = new SqlParameter("@priced", SqlDbType.Float);
            param[4].Value = priced;
            param[5] = new SqlParameter("@ida", SqlDbType.Int);
            param[5].Value = animal;
            update.open();
            update.execop("update_pens", param);
            update.close();
        }
        public void delete_pens(int id)
        {
            DAL.DAL delete = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            delete.open();
            delete.execop("delete_pens", p);
            delete.close();
        }
        public DataTable list_pens()
        {
            DAL.DAL lst_pens = new DAL.DAL();
            DataTable d = new DataTable();
            lst_pens.open();
            d = lst_pens.read_data1("read_pens");
            lst_pens.close();
            return d;
        }
        public DataTable search_pens(string AN)
        {
            DAL.DAL search = new DAL.DAL();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[0].Value = AN;
            DataTable dt = new DataTable();
            dt = search.read_data("search_pens", p);
            return dt;
        }

        //Account CRUD 
        public void insert_user(string usern, string userp, int userr)
        {
            DAL.DAL insert = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@un", SqlDbType.VarChar, 25);
            param[0].Value = usern;
            param[1] = new SqlParameter("@up", SqlDbType.VarChar, 8);
            param[1].Value = userp;
            param[2] = new SqlParameter("@ur", SqlDbType.Int);
            param[2].Value = userr;
            insert.open();
            insert.execop("insert_User", param);
            insert.close();
        }
        public void update_user(int id, string usern, string userp)
        {
            DAL.DAL update = new DAL.DAL();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@un", SqlDbType.VarChar, 25);
            param[1].Value = usern;
            param[2] = new SqlParameter("@up", SqlDbType.VarChar, 8);
            param[2].Value = userp;
            update.open();
            update.execop("update_user", param);
            update.close();
        }
        public DataTable list_users()
        {
            DAL.DAL lst_roles = new DAL.DAL();
            DataTable d = new DataTable();
            lst_roles.open();
            d = lst_roles.read_data1("read_user");
            lst_roles.close();
            return d;
        }
        public DataTable login(string un, string psw)
        {
            DAL.DAL login_user = new DAL.DAL();
            DataTable dt = new DataTable();
            SqlParameter[] pram = new SqlParameter[2];
            pram[0] = new SqlParameter("@un", SqlDbType.VarChar, 25);
            pram[0].Value = un;
            pram[1] = new SqlParameter("@up", SqlDbType.VarChar, 8);
            pram[1].Value = psw;
            login_user.open();
            dt = login_user.read_data("login_user", pram);
            login_user.close();
            return dt;
        }
        public DataTable list_role()
        {
            DAL.DAL lst_roles = new DAL.DAL();
            DataTable d = new DataTable();
            lst_roles.open();
            d = lst_roles.read_data1("select_role");
            lst_roles.close();
            return d;
        }

        public DataTable user_role(string un)
        {
            DAL.DAL login_user = new DAL.DAL();
            DataTable dt = new DataTable();
            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@un", SqlDbType.VarChar, 25);
            pram[0].Value = un;
            login_user.open();
            dt = login_user.read_data("role_user", pram);
            login_user.close();
            return dt;
        }

    }
}
