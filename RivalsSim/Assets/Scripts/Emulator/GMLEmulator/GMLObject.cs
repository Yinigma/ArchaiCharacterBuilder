using RoslynCSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMLObject : MonoBehaviour
{

    protected GMLSymbolTable instanceScope;

    public GMLSymbolTable InstanceScope
    {
        get { return instanceScope;  }
    }

    public virtual void Awake()
    {
        instanceScope = new GMLSymbolTable();
        //basic stuff
        instanceScope.setValue( "id", 0 );
        instanceScope.setValue( "alarm", new int[12] );
        instanceScope.setValue( "depth", 0 );
        instanceScope.setValue( "visible", false );
        instanceScope.setValue( "persistent", false );
        instanceScope.setValue( "solid", false );
        instanceScope.setValue( "object_index", -1 );
        instanceScope.setValue( "layer", 0 );

        instanceScope.setValue("direction", 0 );
        instanceScope.setValue("hspeed", 0.0f);
        instanceScope.setValue("vspeed", 0.0f);
        instanceScope.setValue("gravity", 1);
        instanceScope.setValue("gravity_direction", 270);
        instanceScope.setValue("friction", 1);
        instanceScope.setValue("x", 0.0f);
        instanceScope.setValue("xprevious", 0.0f);
        instanceScope.setValue("xstart", 0.0f);
        instanceScope.setValue("y", 0.0f);
        instanceScope.setValue("yprevious", 0.0f);
        instanceScope.setValue("ystart", 0.0f);

        //sprite variables
        instanceScope.setValue("sprite_index", -1);
        instanceScope.setValue("sprite_width", 0);
        instanceScope.setValue("sprite_height", 0);
        instanceScope.setValue("sprite_xoffset", 0);
        instanceScope.setValue("sprite_yoffset", 0);
        instanceScope.setValue("image_alpha", 0.0f);
        instanceScope.setValue("image_angle", 0.0f);
        instanceScope.setValue("image_index", 0);
        instanceScope.setValue("image_number", 0);
        instanceScope.setValue("image_speed", 0.0f);
        instanceScope.setValue("image_xscale", 0.0f);
        instanceScope.setValue("image_yscale", 0.0f);

        //mask variables
        instanceScope.setValue("bbox_bottom", 0.0f);
        instanceScope.setValue("bbox_left", 0.0f);
        instanceScope.setValue("bbox_right", 0.0f);
        instanceScope.setValue("bbox_top", 0.0f);

        //Legacy physics properties
        instanceScope.setValue("phy_active", null);
        instanceScope.setValue("phy_angular_damping", null);
        instanceScope.setValue("phy_angular_velocity", null);
        instanceScope.setValue("phy_bullet", null);
        instanceScope.setValue("phy_col_normal_x", null);
        instanceScope.setValue("phy_col_normal_y", null);
        instanceScope.setValue("phy_collision_points", null);
        instanceScope.setValue("phy_collision_x", null);
        instanceScope.setValue("phy_collision_y", null);
        instanceScope.setValue("phy_com_x", null);
        instanceScope.setValue("phy_com_y", null);
        instanceScope.setValue("phy_dynamic", null);
        instanceScope.setValue("phy_fixed_rotation", null);
        instanceScope.setValue("phy_inertia", null);
        instanceScope.setValue("phy_kinematic", null);
        instanceScope.setValue("phy_linear_damping", null);
        instanceScope.setValue("phy_linear_velocity_x", null);
        instanceScope.setValue("phy_linear_velocity_y", null);
        instanceScope.setValue("phy_mass", null);
        instanceScope.setValue("phy_position_x", null);
        instanceScope.setValue("phy_position_xprevious", null);
        instanceScope.setValue("phy_position_y", null);
        instanceScope.setValue("phy_position_yprevious", null);
        instanceScope.setValue("phy_rotation", null);
        instanceScope.setValue("phy_sleeping", null);
        instanceScope.setValue("phy_speed", null);
        instanceScope.setValue("phy_speed_x", null);
        instanceScope.setValue("phy_speed_y", null);
    }

    public virtual void Update()
    {
        transform.position = new Vector3( (float) instanceScope.getValue("x"), (float) instanceScope.getValue("y"), (float)instanceScope.getValue("depth") );
    }
}
