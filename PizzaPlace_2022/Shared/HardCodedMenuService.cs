using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Pizzas = new List<Pizza> {
                    
                    new Pizza(4, "Uống Nhầm 1 Ánh Mắt Cơn Say Theo Cả Đời", 50 , Spiciness.Sach1),
                    new Pizza(5, "Mộ Đom Đóm", 60 , Spiciness.Sach2),
                    new Pizza(6, "Truyện Tranh", 65 , Spiciness.Sach3),
                    new Pizza(7, "Cuộc Đời Của PI", 40 , Spiciness.Sach4),
                    new Pizza(8, "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", 70 , Spiciness.Sach5),
                    new Pizza(9, "Đừng Kể Tên Tôi", 80 , Spiciness.Sach6),
                }
             });
    }
}

