using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using HutongGames.PlayMaker;

// Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
public class IAPStoreMgr : MonoBehaviour, IStoreListener
{

    public static IAPStoreMgr instance { set; get; }
    private static IStoreController m_StoreController;          // The Unity Purchasing system.
    private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

    // Global params
    private FsmInt doubleMoves;
    private FsmInt switchOrder;
    private FsmBool allowTopRow;
    private FsmBool act2Enabled;
    private FsmBool premiumFiguresEnabled;

    // consumables
    public static string PRODUCT_3_DOUBLE_MOVES = "double_moves_3";
    public static string PRODUCT_8_DOUBLE_MOVES = "double_moves_6"; // mistake when entered ID
    public static string PRODUCT_12_DOUBLE_MOVES = "double_move_12";

    public static string PRODUCT_3_SWITCH_ORDERS = "switch_order_3";
    public static string PRODUCT_8_SWITCH_ORDERS = "switch_order_6"; // mistake when entered ID
    public static string PRODUCT_12_SWITCH_ORDERS = "switch_order_12";

    public static string PRODUCT_3_OF_EACH = "of_each_3";
    public static string PRODUCT_8_OF_EACH = "of_each_8";
    public static string PRODUCT_12_OF_EACH = "of_each_12";

    // Non consumable
    public static string PRODUCT_TOP_ROW_MOVEMENT = "top_row_movement";
    public static string PRODUCT_ACT_2 = "act_2";
    public static string PRODUCT_PREMIUM_FIGURE_SKIN = "premium_figure_skin";

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        // If we haven't set up the Unity Purchasing reference
        if (m_StoreController == null)
        {
            // Begin to configure our connection to Purchasing
            InitializePurchasing();
        }

        doubleMoves = FsmVariables.GlobalVariables.GetFsmInt("doubleMoveCound");
        switchOrder = FsmVariables.GlobalVariables.GetFsmInt("switchesCount");
        allowTopRow = FsmVariables.GlobalVariables.GetFsmBool("bBoughtAdditionalFields");
        act2Enabled = FsmVariables.GlobalVariables.GetFsmBool("bBoughtAct2");
        premiumFiguresEnabled = FsmVariables.GlobalVariables.GetFsmBool("bBoughtPremiumSkin");
    }

    public void InitializePurchasing()
    {
        // If we have already connected to Purchasing ...
        if (IsInitialized())
        {
            // ... we are done here.
            return;
        }

        // Create a builder, first passing in a suite of Unity provided stores.
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        // Add a product to sell / restore by way of its identifier, associating the general identifier
        // with its store-specific identifiers.
        builder.AddProduct(PRODUCT_3_DOUBLE_MOVES, ProductType.Consumable);
        builder.AddProduct(PRODUCT_8_DOUBLE_MOVES, ProductType.Consumable);
        builder.AddProduct(PRODUCT_12_DOUBLE_MOVES, ProductType.Consumable);

        builder.AddProduct(PRODUCT_3_SWITCH_ORDERS, ProductType.Consumable);
        builder.AddProduct(PRODUCT_8_SWITCH_ORDERS, ProductType.Consumable);
        builder.AddProduct(PRODUCT_12_SWITCH_ORDERS, ProductType.Consumable);

        builder.AddProduct(PRODUCT_3_OF_EACH, ProductType.Consumable);
        builder.AddProduct(PRODUCT_8_OF_EACH, ProductType.Consumable);
        builder.AddProduct(PRODUCT_12_OF_EACH, ProductType.Consumable);

        builder.AddProduct(PRODUCT_TOP_ROW_MOVEMENT, ProductType.NonConsumable);
        builder.AddProduct(PRODUCT_ACT_2, ProductType.NonConsumable);
        builder.AddProduct(PRODUCT_PREMIUM_FIGURE_SKIN, ProductType.NonConsumable);
        // Kick off the remainder of the set-up with an asynchrounous call, passing the configuration 
        // and this class' instance. Expect a response either in OnInitialized or OnInitializeFailed.
        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        // Only say we are initialized if both the Purchasing references are set.
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }
        

    // consumables 
    public void BuyDoubleMoves_3()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_3_DOUBLE_MOVES);
    }
    public void BuyDoubleMoves_8()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_8_DOUBLE_MOVES);
    }
    public void BuyDoubleMoves_12()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_12_DOUBLE_MOVES);
    }
    public void BuySwitchOrder_3()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_3_SWITCH_ORDERS);
    }
    public void BuySwitchOrder_8()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_8_SWITCH_ORDERS);
    }
    public void BuySwitchOrder_12()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_12_SWITCH_ORDERS);
    }
    public void BuyOfEach_3()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_3_OF_EACH);
    }
    public void BuyOfEach_8()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_8_OF_EACH);
    }
    public void BuyOfEach_12()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_12_OF_EACH);
    }

    // nonconsumables
    public void BuyTopRowMovement()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_TOP_ROW_MOVEMENT);
    }
    public void BuyAct2()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_ACT_2);
    }
    public void BuyPremiumFigureSkin()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_PREMIUM_FIGURE_SKIN);
    }


    void BuyProductID(string productId)
    {
        // If Purchasing has been initialized ...
        if (IsInitialized())
        {
            // ... look up the Product reference with the general product identifier and the Purchasing 
            // system's products collection.
            Product product = m_StoreController.products.WithID(productId);

            // If the look up found a product for this device's store and that product is ready to be sold ... 
            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                // ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
                // asynchronously.
                m_StoreController.InitiatePurchase(product);
            }
            // Otherwise ...
            else
            {
                // ... report the product look-up failure situation  
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        // Otherwise ...
        else
        {
            // ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
            // retrying initiailization.
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }


    // Restore purchases previously made by this customer. Some platforms automatically restore purchases, like Google. 
    // Apple currently requires explicit purchase restoration for IAP, conditionally displaying a password prompt.
    public void RestorePurchases()
    {
        // If Purchasing has not yet been set up ...
        if (!IsInitialized())
        {
            // ... report the situation and stop restoring. Consider either waiting longer, or retrying initialization.
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        // If we are running on an Apple device ... 
        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            // ... begin restoring purchases
            Debug.Log("RestorePurchases started ...");

            // Fetch the Apple store-specific subsystem.
            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            // Begin the asynchronous process of restoring purchases. Expect a confirmation response in 
            // the Action<bool> below, and ProcessPurchase if there are previously purchased products to restore.
            apple.RestoreTransactions((result) => {
                // The first phase of restoration. If no more responses are received on ProcessPurchase then 
                // no purchases are available to be restored.
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        // Otherwise ...
        else
        {
            // We are not running on an Apple device. No work is necessary to restore purchases.
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }


    //  
    // --- IStoreListener
    //

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        // Purchasing has succeeded initializing. Collect our Purchasing references.
        Debug.Log("OnInitialized: PASS");

        // Overall Purchasing system, configured with products for this application.
        m_StoreController = controller;
        // Store specific subsystem, for accessing device-specific store features.
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        // A consumable product has been purchased by this user.
        if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_3_DOUBLE_MOVES, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            doubleMoves.Value += 3;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_8_DOUBLE_MOVES, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            doubleMoves.Value += 8;
        }
        // Or ... a subscription product has been purchased by this user.
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_12_DOUBLE_MOVES, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            doubleMoves.Value += 12;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_3_SWITCH_ORDERS, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 3;
        }
        // Or ... a subscription product has been purchased by this user.
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_8_SWITCH_ORDERS, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 8;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_12_SWITCH_ORDERS, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 12;
        }
        // Or ... a subscription product has been purchased by this user.
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_3_OF_EACH, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 3;
            doubleMoves.Value += 3;
        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_8_OF_EACH, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 8;
            doubleMoves.Value += 8;
        }
        // Or ... a subscription product has been purchased by this user.
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_12_OF_EACH, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            switchOrder.Value += 12;
            doubleMoves.Value += 12;
        }

        // Or ... a non-consumable product has been purchased by this user.

        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_TOP_ROW_MOVEMENT, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            allowTopRow.Value = true;
            IAPBuyableBools.SaveAdditionalFields();
        } 
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_ACT_2, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            act2Enabled.Value = true;
            IAPBuyableBools.SaveAct2();
        }
        // Or ... a subscription product has been purchased by this user.
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_PREMIUM_FIGURE_SKIN, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            premiumFiguresEnabled.Value = true;
            IAPBuyableBools.SavePremiumFigures();
        }
        // Or ... an unknown product has been purchased by this user. Fill in additional products here....
        else
        {
            Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }

        // Return a flag indicating whether this product has completely been received, or if the application needs 
        // to be reminded of this purchase at next app launch. Use PurchaseProcessingResult.Pending when still 
        // saving purchased products to the cloud, and when that save is delayed. 
        return PurchaseProcessingResult.Complete;
    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        // A product purchase attempt did not succeed. Check failureReason for more detail. Consider sharing 
        // this reason with the user to guide their troubleshooting actions.
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }
}
