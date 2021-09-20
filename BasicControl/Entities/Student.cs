using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicControl.Entities
{
    public class Student
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ngày sinh. DOB = Date of Birth
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Nơi sinh. POB = Place of Birth
        /// </summary>
        public string POB { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public EGender Gender { get; set; }
        /// <summary>
        /// Quê quán
        /// </summary>
        public string HomeTown { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }

        /// <summary>
        /// Lấy toàn bộ danh sách sinh viên có trong CSDL (MockData)
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetList()
        {
            var ls = new List<Student>();
            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "1",
                FirstName = "Dũng",  
                DOB = new DateTime(2000, 2, 5),
                POB = "Phú Vang",
                HomeTown = "Thừa Thiên Huế",
                Gender = EGender.Nam
            });

            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "2",
                FirstName = "Thị Thơm",
                DOB = new DateTime(2000, 5, 5),
                POB = "Phú Lộc",
                HomeTown = "Đà Nẵng",
                Gender = EGender.Nu
            });

            return ls;
        }

        /// <summary>
        /// Lấy một sinh viên tương ứng với id
        /// </summary>
        /// <param name="id">Mã sinh viên</param>
        /// <returns>
        /// Sinh viên có mã tương ứng là id.
        /// Ngược lại trả về null
        /// </returns>
        public static Student Get(string id)
        {
            var dbStudent = GetList();

            //Theo cách truyền thống đã học
            //for(int i = 0; i < dbStudent.Count; i++)
            //{
            //    if (dbStudent[i].Id == id)
            //        return dbStudent[i];
            //}
            //return null;

            //Theo cách: Linq to SQL, ứng dụng nhiều trong Entity Framework
            //Lamda Expression
            //SQL: Select * from Student where Id = '1'
            var student = dbStudent.Where(s=>s.Id == id).FirstOrDefault();
            return student;

        }
    }
    public enum EGender
    {
        Nam, Nu, Khac
    }
}
