namespace tpmodul10_103022330105
{
    public class Mahasiswa
    {
        private string nama { get; set; }
        private string nim { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string NIM
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}

