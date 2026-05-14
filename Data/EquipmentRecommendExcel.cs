using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DanhengPlugin.DHConsoleCommands.Data;

[ResourceEntity("EquipmentRecommend.json")]
public class EquipmentRecommendExcel : ExcelResource
{
    public int AvatarID { get; set; }
    
    // 推荐的光锥ID列表
    public List<int> EquipmentIDList { get; set; } = [];

    public override int GetId()
    {
        // 使用角色ID作为索引键
        return AvatarID;
    }

    public override void Loaded()
    {
        // 映射到插件全局数据字典中
        PluginGameData.EquipmentRecommendData[AvatarID] = this;
    }
}
