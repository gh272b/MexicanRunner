﻿using System.Collections;
    // Update is called once per frame
    
        if (GetComponentInParent<RollingStone>() == true)
        {
            pos = GetComponentInParent<RollingStone>().gameObject.transform.position;
            pos.y = yO;
            transform.position = pos;
        }
        else
        {
            pos = transform.position;
            pos.y = yO;
            transform.position = pos;
        //    if(gameObject.GetComponentInParent<RollingStone>() == true)
        //    {
        //        Debug.Log($"trans.pos = {transform.position} and ParentPos = {GetComponentInParent<RollingStone>().gameObject.transform.position} and pos = {pos}");
        //    }
    }