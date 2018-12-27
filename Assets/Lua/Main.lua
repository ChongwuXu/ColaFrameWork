--主入口函数。从这里开始lua逻辑
local rawset = rawset

-- 全局函数
-- 用于声明全局变量
function define(name,value)
	rawset(_G,name,value)
end

local function initialize()
	LuaLogHelper.initialize()

	-- 模块初始化
	ModuleManager:Instance():RegisterAllModules()
	ModuleManager:Instance():InitAllModules()
end

-- 在此处定义注册一些全局变量
local function gloablDefine()
	-- 必须首先注册全局Class,顺序敏感
	define("Class",require("Core.middleclass"))
	define("LuaLogHelper",require("Utilitys.LuaLogHelper"))
    define("TableHelper","Utilitys.TableHelper")
	define("EventMgr",require("Mgrs.EventMgr"))
	define("CommonUtility",require("Utilitys.CommonUtility"))
	define("ConfigMgr",require("Mgrs.ConfigMgr"))
	define("ModuleManager",require("Mgrs.ModuleManager"))
	define("UIUtils",require("Utilitys.UIUtils"))
	--控制全局变量的新建与访问
	require("Utilitys.LuaGlobalCheck")
end

-- 初始化一些参数
local function initParam()
	-- 初始化随机种子
	math.randomseed(tostring(os.time()):reverse():sub(1, 6))
end

local function EventTest(param)
	print("------------>接受到参数",param)
end

function Main()
	gloablDefine()
	initParam()
	initialize()

	--测试对全局变量的访问与新建]
	_G.aa = 123
	print(_G.aa)

	local obj = CommonHelper.InstantiateGoByID(101, GUIHelper.GetUIRootObj())
	local progressText = obj.FindChildByPath("progress_text")
	progressText.text = "测试ABC"

	EventMgr:Instance():RegisterEvent(1,2,EventTest)
	EventMgr:Instance():DispatchEvent(1,2,{key = "123",value= 456,"abc",123})
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end