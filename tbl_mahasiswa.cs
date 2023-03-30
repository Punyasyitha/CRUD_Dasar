using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Db_temankelas
{
    #region Tbl_mahasiswa
    public class Tbl_mahasiswa
    {
        #region Member Variables
        protected int _No;
        protected string _NRP;
        protected string _Nama;
        protected string _Jenis_Kelamin;
        protected string _Jurusan;
        protected string _Email;
        protected string _Alamat;
        protected string _No_Handphone;
        protected string _Asal_Sekolah;
        protected string _Matkul_Favorit;
        #endregion
        #region Constructors
        public Tbl_mahasiswa() { }
        public Tbl_mahasiswa(string NRP, string Nama, string Jenis_Kelamin, string Jurusan, string Email, string Alamat, string No_Handphone, string Asal_Sekolah, string Matkul_Favorit)
        {
            this._NRP=NRP;
            this._Nama=Nama;
            this._Jenis_Kelamin=Jenis_Kelamin;
            this._Jurusan=Jurusan;
            this._Email=Email;
            this._Alamat=Alamat;
            this._No_Handphone=No_Handphone;
            this._Asal_Sekolah=Asal_Sekolah;
            this._Matkul_Favorit=Matkul_Favorit;
        }
        #endregion
        #region Public Properties
        public virtual int No
        {
            get {return _No;}
            set {_No=value;}
        }
        public virtual string NRP
        {
            get {return _NRP;}
            set {_NRP=value;}
        }
        public virtual string Nama
        {
            get {return _Nama;}
            set {_Nama=value;}
        }
        public virtual string Jenis_Kelamin
        {
            get {return _Jenis_Kelamin;}
            set {_Jenis_Kelamin=value;}
        }
        public virtual string Jurusan
        {
            get {return _Jurusan;}
            set {_Jurusan=value;}
        }
        public virtual string Email
        {
            get {return _Email;}
            set {_Email=value;}
        }
        public virtual string Alamat
        {
            get {return _Alamat;}
            set {_Alamat=value;}
        }
        public virtual string No_Handphone
        {
            get {return _No_Handphone;}
            set {_No_Handphone=value;}
        }
        public virtual string Asal_Sekolah
        {
            get {return _Asal_Sekolah;}
            set {_Asal_Sekolah=value;}
        }
        public virtual string Matkul_Favorit
        {
            get {return _Matkul_Favorit;}
            set {_Matkul_Favorit=value;}
        }
        #endregion
    }
    #endregion
}