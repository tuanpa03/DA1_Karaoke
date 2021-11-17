using _1_DAL.DAL_Service;
using _1_DAL.Entities;
using _1_DAL.IDAL_Service;
using _2_BUS.IBUS_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.BUS_Service
{
    public class BUS_ChiTietHoaDonBan_Service : IBUS_ChiTietHoaDonBan_Service
    {
        private IDAL_ChiTietHoaDonBan_Service _iDAL_ChiTietHoaDonBan_Service;
        public BUS_ChiTietHoaDonBan_Service()
        {
            _iDAL_ChiTietHoaDonBan_Service = new DAL_ChiTietHoaDonBan_Service();
        }
        public bool Add(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            return _iDAL_ChiTietHoaDonBan_Service.Add(chiTietHoaDonBan);
        }

        public List<ChiTietHoaDonBan> Find(int id)
        {
            return _iDAL_ChiTietHoaDonBan_Service.Find(id);
        }

        public List<ChiTietHoaDonBan> FindName(int name)
        {
            return _iDAL_ChiTietHoaDonBan_Service.FindName(name);
        }

        public void GetlstChiTietHoaDonBan()
        {
            _iDAL_ChiTietHoaDonBan_Service.GetlstChiTietHoaDonBan();
        }

        public bool Remove(int idHoaDon)
        {
            return _iDAL_ChiTietHoaDonBan_Service.Remove(idHoaDon);
        }

        public bool Save()
        {
            return _iDAL_ChiTietHoaDonBan_Service.Save();
        }

        public List<ChiTietHoaDonBan> sendlstChiTietHoaDonBan()
        {
            return _iDAL_ChiTietHoaDonBan_Service.sendlstChiTietHoaDonBan();
        }

        public bool Update(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            return _iDAL_ChiTietHoaDonBan_Service.Update(chiTietHoaDonBan);
        }
    }
}
