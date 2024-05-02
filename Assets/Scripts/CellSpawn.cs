using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

// https://hatebin.com/djopeoypji

public class CellSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;

    private Realtime _realtime;
    private RealtimeAvatarManager _avatarManager;


    // GameObject that moves avatar to specified spawn point (attach to "Root" of Normal Local Avatar):
    [SerializeField] private GameObject spawnMarker;

    // Track whether avatar has been moved or not: 
    private bool avatarMoved = false;

    private int rand;

    private void Awake()
    {
        _realtime = FindObjectOfType<Realtime>();
        _avatarManager = _realtime.GetComponent<RealtimeAvatarManager>();

        _realtime.didConnectToRoom += ConnectedToRoom;
    }

    private void Start()
    {
        //if (!setHost.isHost)
        //{
        //    _realtime.Connect(setHost.clientRoomCodeToConnect);
        //}

        // random number to decide what cell to send clientIDs to
        // rand = Random.Range(0, 2);
        rand = 0;

    }

    public void ConnectedToRoom(Realtime realtime)
    {
        PosAvatar(); //after connecting successfully to the room, position the avatar.
    }

    public void PosAvatar()
    {
        UnityEngine.Debug.Log(_realtime.clientID);

        //when the user connects, check their clientID and move them to the spawn point for their ClientID.

        if (avatarMoved == false) //!setHost.isHost && )
        {
            // send every other player to spawnPoints[0] or [1]
            int spawnIndex = (_realtime.clientID + rand) % 2;

            spawnMarker.transform.localPosition = spawnPoints[spawnIndex].position;
            spawnMarker.transform.localRotation = spawnPoints[spawnIndex].rotation;

            avatarMoved = true;
        }

    }
}
