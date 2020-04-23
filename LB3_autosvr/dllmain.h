// dllmain.h : Declaration of module class.

class CLB3_autosvrModule : public ATL::CAtlDllModuleT< CLB3_autosvrModule >
{
public :
	DECLARE_LIBID(LIBID_LB3_autosvrLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_LB3_AUTOSVR, "{0DC3A73C-2541-4CB1-8654-4CCA3972FDC2}")
};

extern class CLB3_autosvrModule _AtlModule;
