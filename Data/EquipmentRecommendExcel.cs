using EggLink.DanhengServer.Data;
using Newtonsoft.Json;

namespace DanhengPlugin.DHConsoleCommands.Data;

[ResourceEntity("AvatarEquipRecommend.json")]
public class EquipmentRecommendExcel : ExcelResource
{
    /// <summary>
    /// 角色ID
    /// </summary>
    [JsonProperty("AvatarID")]
    public int AvatarID { get; set; }
    
    /// <summary>
    /// 推荐光锥ID列表 (优先级从高到低)
    /// 索引0: 最优推荐
    /// 索引1: 备选1
    /// 索引2: 备选2
    /// </summary>
    [JsonProperty("EquipmentList")]
    public List<int> EquipmentList { get; set; } = [];

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
