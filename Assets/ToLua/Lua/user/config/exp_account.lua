-- AutoGenerate, Do not Edit!
local t = {}
local indexs={
'lv','exp','exp_total','pve_action'
}

t.t = {
	['1']={'1','60','60','10'},
	['2']={'2','60','120','10'},
	['3']={'3','60','180','10'},
	['4']={'4','60','240','10'},
	['5']={'5','60','300','10'},
	['6']={'6','60','360','10'},
	['7']={'7','70','430','10'},
	['8']={'8','110','540','10'},
	['9']={'9','170','710','10'},
	['10']={'10','240','950','10'},
	['11']={'11','330','1280','20'},
	['12']={'12','440','1720','20'},
	['13']={'13','580','2300','20'},
	['14']={'14','750','3050','20'},
	['15']={'15','960','4010','20'},
	['16']={'16','1220','5230','20'},
	['17']={'17','1410','6640','20'},
	['18']={'18','1640','8280','20'},
	['19']={'19','1890','10170','20'},
	['20']={'20','2150','12320','20'},
	['21']={'21','2450','14770','40'},
	['22']={'22','2770','17540','40'},
	['23']={'23','3120','20660','40'},
	['24']={'24','3500','24160','40'},
	['25']={'25','3910','28070','40'},
	['26']={'26','4360','32430','40'},
	['27']={'27','4830','37260','40'},
	['28']={'28','5340','42600','40'},
	['29']={'29','5880','48480','40'},
	['30']={'30','6460','54940','40'},
	['31']={'31','7080','62020','40'},
	['32']={'32','7740','69760','40'},
	['33']={'33','8430','78190','40'},
	['34']={'34','9170','87360','40'},
	['35']={'35','9950','97310','40'},
	['36']={'36','10780','108090','40'},
	['37']={'37','11640','119730','40'},
	['38']={'38','12560','132290','40'},
	['39']={'39','13520','145810','40'},
	['40']={'40','15180','160990','40'},
	['41']={'41','16920','177910','40'},
	['42']={'42','18750','196660','40'},
	['43']={'43','20660','217320','40'},
	['44']={'44','22650','239970','40'},
	['45']={'45','24740','264710','40'},
	['46']={'46','26910','291620','40'},
	['47']={'47','29170','320790','40'},
	['48']={'48','31520','352310','40'},
	['49']={'49','33960','386270','40'},
	['50']={'50','36500','422770','40'},
	['51']={'51','39130','461900','40'},
	['52']={'52','41860','503760','40'},
	['53']={'53','44680','548440','40'},
	['54']={'54','47610','596050','40'},
	['55']={'55','50630','646680','40'},
	['56']={'56','53750','700430','40'},
	['57']={'57','56970','757400','40'},
	['58']={'58','60300','817700','40'},
	['59']={'59','63720','881420','40'},
	['60']={'60','67260','948680','40'},
	['61']={'61','67260','1015940','40'},
	['62']={'62','67260','1083200','40'},
	['63']={'63','67260','1150460','40'},
	['64']={'64','67260','1217720','40'},
	['65']={'65','67260','1284980','40'},
	['66']={'66','67260','1352240','40'},
	['67']={'67','67260','1419500','40'},
	['68']={'68','67260','1486760','40'},
	['69']={'69','67260','1554020','40'},
	['70']={'70','67260','1621280','40'},
	['71']={'71','67260','1688540','40'},
	['72']={'72','67260','1755800','40'},
	['73']={'73','67260','1823060','40'},
	['74']={'74','67260','1890320','40'},
	['75']={'75','67260','1957580','40'},
	['76']={'76','67260','2024840','40'},
	['77']={'77','67260','2092100','40'},
	['78']={'78','67260','2159360','40'},
	['79']={'79','67260','2226620','40'},
	['80']={'80','67260','2293880','40'},
	['81']={'81','67260','2361140','40'},
	['82']={'82','67260','2428400','40'},
	['83']={'83','67260','2495660','40'},
	['84']={'84','67260','2562920','40'},
	['85']={'85','67260','2630180','40'},
	['86']={'86','67260','2697440','40'},
	['87']={'87','67260','2764700','40'},
	['88']={'88','67260','2831960','40'},
	['89']={'89','67260','2899220','40'},
	['90']={'90','67260','2966480','40'},
	['91']={'91','67260','3033740','40'},
	['92']={'92','67260','3101000','40'},
	['93']={'93','67260','3168260','40'},
	['94']={'94','67260','3235520','40'},
	['95']={'95','67260','3302780','40'},
	['96']={'96','67260','3370040','40'},
	['97']={'97','67260','3437300','40'},
	['98']={'98','67260','3504560','40'},
	['99']={'99','67260','3571820','40'},
	['100']={'100','67260','3639080','40'}
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
