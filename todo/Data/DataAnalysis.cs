using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    public static class DataAnalysis
    {
        public static List<DataAnalysisDTO> DataAnalysisDTO(Guid userId)
        {
            List<DataAnalysisDTO> dataAnalysisDTO = new List<DataAnalysisDTO>();
            var data = InventoryService.GetAll(userId);
            foreach (var item in data)
            {
                dataAnalysisDTO.Add(new DataAnalysisDTO { TitleName = item.Item, ValueCount = item.QuantityInInventory});
            }
            return dataAnalysisDTO;
        }
    }

    public class DataAnalysisDTO
    {
        public string TitleName { get; set; }
        public int ValueCount { get; set; }
    }

}
