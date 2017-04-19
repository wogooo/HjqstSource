local t = activity_base_view.activity_view()
local name = 'activity_present_view'

local activity_ctrl = gamemanager.GetCtrl('activity_controller')
local activity_model = gamemanager.GetModel('activity_model')
local event_data = gamemanager.GetData('event_data')
local activity_present_item = require("ui/activity/view/present/activity_present_item")

t._TextTitle = nil
t._Text1 = nil
t._Text2 = nil
t.scrollcontent = nil
t.cotick = nil
t.ItemDataList = {}
t.m_aryScrollItem = {}

function t:Start(btype)
  activity_base_view.Start(self, btype)
  self.transform.localPosition = Vector3(0,33,0)
  self._TextTitle = self.transform:FindChild('right/title/Text'):GetComponent(typeof(Text))
  self._Text1 = self.transform:FindChild('right/titletime'):GetComponent(typeof(Text))
  self._Text2 = self.transform:FindChild('right/titletime/time'):GetComponent(typeof(Text))  
  self.scrollcontent = self.transform:FindChild('right/scrollrect/viewport/content'):GetComponent(typeof(ScrollContent))
  self.scrollcontent.onResetItem:RemoveAllListeners()
	self.scrollcontent.onResetItem:AddListener(function(go, index) self:OnItemInit(go, index) end)
  self:Init()
end

function t:Open() 
  activity_base_view.Open(self)
end

function t:Init()
  activity_base_view.Init(self)
  
  local data = event_data.GetDataByType(self.type)
  if nil == data then do return end end
  
  self._TextTitle.text = LocalizationController.instance:Get(data.event_name)  
  self._Text1.text = LocalizationController.instance:Get('event_public_time')..':'  
  self._Text2.text = LocalizationController.instance:Get(data.event_describe)
  
  self.ItemDataList = self:GetListData()
  self:InitItems()
end

function t:InitItems()
  self.scrollcontent:Init(#self.ItemDataList, false, 0)
end

function t:Refresh()
  activity_base_view.Refresh(self)
  self:RefreshScrollContent()
end

function t:ActivityUpdate()
  activity_base_view.ActivityUpdate(self)
  self:RefreshScrollContent()
end

function t:RefreshScrollContent()
  self.ItemDataList = self:GetListData()
  self.scrollcontent:RefreshAllContentItems()
end

function t:OnItemInit(go, index)
  local itemdata = self:GetItemByIndex(index + 1)
  if nil == itemdata then do return end end
  
   if self.m_aryScrollItem[go] == nil then
      self.m_aryScrollItem[go]= activity_present_item.New(go.transform)
      self.m_aryScrollItem[go].DelegateOnClick:RemoveAllListener()
      self.m_aryScrollItem[go].DelegateOnClick:AddListener(function(info) self:OnGetRewardBtnClick(info) end) 
  end
  
  t.m_aryScrollItem[go]:Init(itemdata) 
end

function t:GetItemByIndex(index)
  for i = 1, #self.ItemDataList do if i == index then return self.ItemDataList[i] end end
end

function t:OnGetRewardBtnClick(info)
  activity_ctrl.ReqActivityReward(info.type, info.id, info.subType)
end

function t:OnTimerTick()
  t:Refresh()
end

function t:Close()
  activity_base_view.Close(self)
end

return t