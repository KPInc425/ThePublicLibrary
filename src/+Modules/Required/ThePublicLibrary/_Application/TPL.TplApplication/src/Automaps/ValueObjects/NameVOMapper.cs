﻿namespace TPL.TplApplication.Automaps;
public class NameVOMapper : Profile
{
    public override string ProfileName
    {
        get { return "NameVO Map"; }
    }

    public NameVOMapper()
    {
        CreateMap<NameVO, NameVOViewModel>();
    }
}