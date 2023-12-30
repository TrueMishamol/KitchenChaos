using Unity.Netcode;
using UnityEngine;

public interface IKitchenObjectParent {

    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public KitchenObject GetKitchenObject();

    public void ClearKittchenObject();

    public bool HasKitchenObject();

    public NetworkObject GetNetworkObject();
}
