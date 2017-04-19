-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
module('explore_pb')


local EXPLORETASKPROTO = protobuf.Descriptor();
local EXPLORETASKPROTO_ID_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKPROTO_STATUS_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKPROTO_HEROS_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKPROTO_OVERTIME_FIELD = protobuf.FieldDescriptor();
local EXPLORELISTRESP = protobuf.Descriptor();
local EXPLORELISTRESP_EXPLORETASKS_FIELD = protobuf.FieldDescriptor();
local EXPLORELISTRESP_REMAINTIMES_FIELD = protobuf.FieldDescriptor();
local EXPLORELISTRESP_MAXTIMES_FIELD = protobuf.FieldDescriptor();
local EXPLORELISTRESP_FREEREFRESHISUSED_FIELD = protobuf.FieldDescriptor();
local EXPLORELISTRESP_EXPLOREDHEROS_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKREQ = protobuf.Descriptor();
local EXPLORETASKREQ_ID_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKREQ_HEROS_FIELD = protobuf.FieldDescriptor();
local EXPLORETASKREFRESHRESP = protobuf.Descriptor();
local EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD = protobuf.FieldDescriptor();

EXPLORETASKPROTO_ID_FIELD.name = "id"
EXPLORETASKPROTO_ID_FIELD.full_name = ".explore.ExploreTaskProto.id"
EXPLORETASKPROTO_ID_FIELD.number = 1
EXPLORETASKPROTO_ID_FIELD.index = 0
EXPLORETASKPROTO_ID_FIELD.label = 2
EXPLORETASKPROTO_ID_FIELD.has_default_value = false
EXPLORETASKPROTO_ID_FIELD.default_value = 0
EXPLORETASKPROTO_ID_FIELD.type = 5
EXPLORETASKPROTO_ID_FIELD.cpp_type = 1

EXPLORETASKPROTO_STATUS_FIELD.name = "status"
EXPLORETASKPROTO_STATUS_FIELD.full_name = ".explore.ExploreTaskProto.status"
EXPLORETASKPROTO_STATUS_FIELD.number = 2
EXPLORETASKPROTO_STATUS_FIELD.index = 1
EXPLORETASKPROTO_STATUS_FIELD.label = 1
EXPLORETASKPROTO_STATUS_FIELD.has_default_value = false
EXPLORETASKPROTO_STATUS_FIELD.default_value = 0
EXPLORETASKPROTO_STATUS_FIELD.type = 5
EXPLORETASKPROTO_STATUS_FIELD.cpp_type = 1

EXPLORETASKPROTO_HEROS_FIELD.name = "heros"
EXPLORETASKPROTO_HEROS_FIELD.full_name = ".explore.ExploreTaskProto.heros"
EXPLORETASKPROTO_HEROS_FIELD.number = 3
EXPLORETASKPROTO_HEROS_FIELD.index = 2
EXPLORETASKPROTO_HEROS_FIELD.label = 3
EXPLORETASKPROTO_HEROS_FIELD.has_default_value = false
EXPLORETASKPROTO_HEROS_FIELD.default_value = {}
EXPLORETASKPROTO_HEROS_FIELD.type = 5
EXPLORETASKPROTO_HEROS_FIELD.cpp_type = 1

EXPLORETASKPROTO_OVERTIME_FIELD.name = "overTime"
EXPLORETASKPROTO_OVERTIME_FIELD.full_name = ".explore.ExploreTaskProto.overTime"
EXPLORETASKPROTO_OVERTIME_FIELD.number = 4
EXPLORETASKPROTO_OVERTIME_FIELD.index = 3
EXPLORETASKPROTO_OVERTIME_FIELD.label = 1
EXPLORETASKPROTO_OVERTIME_FIELD.has_default_value = false
EXPLORETASKPROTO_OVERTIME_FIELD.default_value = 0
EXPLORETASKPROTO_OVERTIME_FIELD.type = 3
EXPLORETASKPROTO_OVERTIME_FIELD.cpp_type = 2

EXPLORETASKPROTO.name = "ExploreTaskProto"
EXPLORETASKPROTO.full_name = ".explore.ExploreTaskProto"
EXPLORETASKPROTO.nested_types = {}
EXPLORETASKPROTO.enum_types = {}
EXPLORETASKPROTO.fields = {EXPLORETASKPROTO_ID_FIELD, EXPLORETASKPROTO_STATUS_FIELD, EXPLORETASKPROTO_HEROS_FIELD, EXPLORETASKPROTO_OVERTIME_FIELD}
EXPLORETASKPROTO.is_extendable = false
EXPLORETASKPROTO.extensions = {}
EXPLORELISTRESP_EXPLORETASKS_FIELD.name = "exploreTasks"
EXPLORELISTRESP_EXPLORETASKS_FIELD.full_name = ".explore.ExploreListResp.exploreTasks"
EXPLORELISTRESP_EXPLORETASKS_FIELD.number = 1
EXPLORELISTRESP_EXPLORETASKS_FIELD.index = 0
EXPLORELISTRESP_EXPLORETASKS_FIELD.label = 3
EXPLORELISTRESP_EXPLORETASKS_FIELD.has_default_value = false
EXPLORELISTRESP_EXPLORETASKS_FIELD.default_value = {}
EXPLORELISTRESP_EXPLORETASKS_FIELD.message_type = EXPLORETASKPROTO
EXPLORELISTRESP_EXPLORETASKS_FIELD.type = 11
EXPLORELISTRESP_EXPLORETASKS_FIELD.cpp_type = 10

EXPLORELISTRESP_REMAINTIMES_FIELD.name = "remainTimes"
EXPLORELISTRESP_REMAINTIMES_FIELD.full_name = ".explore.ExploreListResp.remainTimes"
EXPLORELISTRESP_REMAINTIMES_FIELD.number = 2
EXPLORELISTRESP_REMAINTIMES_FIELD.index = 1
EXPLORELISTRESP_REMAINTIMES_FIELD.label = 2
EXPLORELISTRESP_REMAINTIMES_FIELD.has_default_value = false
EXPLORELISTRESP_REMAINTIMES_FIELD.default_value = 0
EXPLORELISTRESP_REMAINTIMES_FIELD.type = 5
EXPLORELISTRESP_REMAINTIMES_FIELD.cpp_type = 1

EXPLORELISTRESP_MAXTIMES_FIELD.name = "maxTimes"
EXPLORELISTRESP_MAXTIMES_FIELD.full_name = ".explore.ExploreListResp.maxTimes"
EXPLORELISTRESP_MAXTIMES_FIELD.number = 3
EXPLORELISTRESP_MAXTIMES_FIELD.index = 2
EXPLORELISTRESP_MAXTIMES_FIELD.label = 2
EXPLORELISTRESP_MAXTIMES_FIELD.has_default_value = false
EXPLORELISTRESP_MAXTIMES_FIELD.default_value = 0
EXPLORELISTRESP_MAXTIMES_FIELD.type = 5
EXPLORELISTRESP_MAXTIMES_FIELD.cpp_type = 1

EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.name = "freeRefreshIsUsed"
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.full_name = ".explore.ExploreListResp.freeRefreshIsUsed"
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.number = 4
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.index = 3
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.label = 1
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.has_default_value = false
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.default_value = false
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.type = 8
EXPLORELISTRESP_FREEREFRESHISUSED_FIELD.cpp_type = 7

EXPLORELISTRESP_EXPLOREDHEROS_FIELD.name = "exploredHeros"
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.full_name = ".explore.ExploreListResp.exploredHeros"
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.number = 5
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.index = 4
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.label = 3
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.has_default_value = false
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.default_value = {}
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.type = 5
EXPLORELISTRESP_EXPLOREDHEROS_FIELD.cpp_type = 1

EXPLORELISTRESP.name = "ExploreListResp"
EXPLORELISTRESP.full_name = ".explore.ExploreListResp"
EXPLORELISTRESP.nested_types = {}
EXPLORELISTRESP.enum_types = {}
EXPLORELISTRESP.fields = {EXPLORELISTRESP_EXPLORETASKS_FIELD, EXPLORELISTRESP_REMAINTIMES_FIELD, EXPLORELISTRESP_MAXTIMES_FIELD, EXPLORELISTRESP_FREEREFRESHISUSED_FIELD, EXPLORELISTRESP_EXPLOREDHEROS_FIELD}
EXPLORELISTRESP.is_extendable = false
EXPLORELISTRESP.extensions = {}
EXPLORETASKREQ_ID_FIELD.name = "id"
EXPLORETASKREQ_ID_FIELD.full_name = ".explore.ExploreTaskReq.id"
EXPLORETASKREQ_ID_FIELD.number = 1
EXPLORETASKREQ_ID_FIELD.index = 0
EXPLORETASKREQ_ID_FIELD.label = 2
EXPLORETASKREQ_ID_FIELD.has_default_value = false
EXPLORETASKREQ_ID_FIELD.default_value = 0
EXPLORETASKREQ_ID_FIELD.type = 5
EXPLORETASKREQ_ID_FIELD.cpp_type = 1

EXPLORETASKREQ_HEROS_FIELD.name = "heros"
EXPLORETASKREQ_HEROS_FIELD.full_name = ".explore.ExploreTaskReq.heros"
EXPLORETASKREQ_HEROS_FIELD.number = 2
EXPLORETASKREQ_HEROS_FIELD.index = 1
EXPLORETASKREQ_HEROS_FIELD.label = 3
EXPLORETASKREQ_HEROS_FIELD.has_default_value = false
EXPLORETASKREQ_HEROS_FIELD.default_value = {}
EXPLORETASKREQ_HEROS_FIELD.type = 5
EXPLORETASKREQ_HEROS_FIELD.cpp_type = 1

EXPLORETASKREQ.name = "ExploreTaskReq"
EXPLORETASKREQ.full_name = ".explore.ExploreTaskReq"
EXPLORETASKREQ.nested_types = {}
EXPLORETASKREQ.enum_types = {}
EXPLORETASKREQ.fields = {EXPLORETASKREQ_ID_FIELD, EXPLORETASKREQ_HEROS_FIELD}
EXPLORETASKREQ.is_extendable = false
EXPLORETASKREQ.extensions = {}
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.name = "refreshTasks"
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.full_name = ".explore.ExploreTaskRefreshResp.refreshTasks"
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.number = 1
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.index = 0
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.label = 3
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.has_default_value = false
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.default_value = {}
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.message_type = EXPLORETASKPROTO
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.type = 11
EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD.cpp_type = 10

EXPLORETASKREFRESHRESP.name = "ExploreTaskRefreshResp"
EXPLORETASKREFRESHRESP.full_name = ".explore.ExploreTaskRefreshResp"
EXPLORETASKREFRESHRESP.nested_types = {}
EXPLORETASKREFRESHRESP.enum_types = {}
EXPLORETASKREFRESHRESP.fields = {EXPLORETASKREFRESHRESP_REFRESHTASKS_FIELD}
EXPLORETASKREFRESHRESP.is_extendable = false
EXPLORETASKREFRESHRESP.extensions = {}

ExploreListResp = protobuf.Message(EXPLORELISTRESP)
ExploreTaskProto = protobuf.Message(EXPLORETASKPROTO)
ExploreTaskRefreshResp = protobuf.Message(EXPLORETASKREFRESHRESP)
ExploreTaskReq = protobuf.Message(EXPLORETASKREQ)

