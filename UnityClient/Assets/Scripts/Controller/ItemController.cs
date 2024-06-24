using System;
using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Protocol;
using UnityEngine;

public class ItemController : CreatureController
{
    protected override void Init()
    {
        State = CreatureState.Moving;
        base.Init();
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActiveItem(other.gameObject);
        }
    }

    protected override void UpdateAnimation()
    {
        // TODO
    }

    protected void ActiveItem(GameObject player)
    {
        MyPlayerController mc = player.GetComponent<MyPlayerController>();

        C_ItemGet cItemPacket = new C_ItemGet { ItemInfo = new ItemInfo() };
        Debug.Log($"Creature {Id} Item Get");
        cItemPacket.ItemInfo.ItemId = Id;
        cItemPacket.ItemInfo.Name = "Coin";
        cItemPacket.ItemInfo.PosInfo = PosInfo;
        cItemPacket.PlayerObjectId = mc.Id;
        Managers.Network.Send(cItemPacket);
        Debug.Log($"Creature {mc.Id} Item Get");
    }
}
