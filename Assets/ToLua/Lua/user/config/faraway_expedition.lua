-- AutoGenerate, Do not Edit!
local t = {}
local indexs={
'id','type','reward_show','reward','position','chapter','prefab','comat_min','comat_max','pre_id'
}

t.t = {
	['101']={'101','1','16:0:10:0','551','-23.6;43.81','1',nil,'30','35','0'},
	['102']={'102','1','16:0:10:0','552','152.7;-18','1',nil,'35','40','101'},
	['103']={'103','1','16:0:10:0','553','287.1;12.9','1',nil,'40','45','102'},
	['104']={'104','2','16:0:100:0;8:0:1000:0','554','450.3;51.7','1',nil,'40','45','103'},
	['105']={'105','1','16:0:10:0','555','537.6;-60.7','1',nil,'40','45','104'},
	['106']={'106','1','16:0:10:0','556','662.1;28.3','1',nil,'45','50','105'},
	['107']={'107','1','16:0:10:0','557','812.83;46.3','1',nil,'50','55','106'},
	['108']={'108','2','16:0:100:0;8:0:2000:0','558','920.2;1.9','1',nil,'50','55','107'},
	['109']={'109','1','16:0:10:0','559','988.9;-64','1',nil,'55','60','108'},
	['110']={'110','1','16:0:10:0','560','1206.5;-85','1',nil,'60','65','109'},
	['111']={'111','1','16:0:10:0','561','1263.9;-9','1',nil,'62','67','110'},
	['112']={'112','2','16:0:200:0;8:0:5000:0','562','1114.3;-42','1',nil,'65','70','111'},
	['113']={'113','1','16:0:10:0','563','1190;25','1',nil,'68','73','112'},
	['114']={'114','1','16:0:10:0','564','1365.4;97','1',nil,'70','75','113'},
	['115']={'115','1','16:0:10:0','565','1501;77','1',nil,'72','77','114'},
	['116']={'116','2','16:0:300:0;8:0:10000:0','566','1510.4;-96','1',nil,'75','80','115'},
	['117']={'117','1','16:0:10:0','567','1737.6;-154','1',nil,'78','83','116'},
	['118']={'118','1','16:0:10:0','568','1873.8;-45','1',nil,'80','85','117'},
	['119']={'119','1','16:0:10:0','569','1683.1;2','1',nil,'82','87','118'},
	['120']={'120','3','16:0:500:0;8:0:15000:0','570','1780.9;39','1',nil,'85','90','119'}
}

function t.ForEach(func)
	if not func then return end
	local ky = nil
	local v = nil
	for i,j in pairs(t.t) do
		local r={}
		ky=tonumber(i)
		for k=1,#indexs do
			v=indexs[k]
			if v and v ~= '' then
				r[v]=j[k]
			end
		end

		if ky then func(ky,r) 
		else func(i,r) end
	end
end

function t.GetItem(id)
	id=tostring(id)
    local item=t[id]
	if item then return item end
	item=t.t[id]
	local result = {}
	local v = nil
	for i=1,#indexs do
		v=indexs[i]
		if v and v ~= '' then
			result[v]=item[i]
		end
	end
	t[id]=result
	return result
end

return t