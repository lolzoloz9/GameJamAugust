﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkAreaController : MonoBehaviour {
    public Button DataMineButton;
    public Button DeployAdButton;
    public Button MonetizeButton;
    public Button GigWorkersButton;
    public Button AutomateButton;
    public Button AcquihireButton;
    public Button BlockchainButton;
    public Button MixedRealityButton;
    public Button MindUploadingButton;

    public Button AcquisitionsButton;
    public Button ResearchButton;

    public int DataSetsCount;
    public int RevenueCount;
    public int UsersCount;
    public int PentaPointsCount;
    public int WorkersCount;

    private int MonetizationLoops;
    private int WorkersEarned;

    public Text DataSetsText;
    public Text RevenueText;
    public Text UsersText;
    public Text PentaPointsText;
    public Text WorkersText;

    public Image HappyFunTimes;

    private float time;

    private void Start() {
        DataSetsCount = 0;
        RevenueCount = 500;
        UsersCount = 0;
        PentaPointsCount = 0;
        WorkersCount = 0;
        MonetizationLoops = 0;

        AcquisitionsButton.interactable = false;
        ResearchButton.interactable = false;

        SetCountText();
    }

    public void SetCountText() {
        DataSetsText.text = DataSetsCount.ToString();
        RevenueText.text = "$" + RevenueCount.ToString();
        UsersText.text = UsersCount.ToString();
        PentaPointsText.text = PentaPointsCount.ToString();
        WorkersText.text = WorkersCount.ToString();
    }

    public void Update() {
        if(MonetizationLoops>=3) {
            AcquisitionsButton.interactable = true;
        }

        if(WorkersEarned>=100) {
            ResearchButton.interactable = true;
        }
    }


    public void DataMine() {
        if (UsersCount >= 200) {
            DataSetsCount+=200;
            UsersCount-=200;
            SetCountText();
            StartCoroutine(DisableButton(DataMineButton, 17f));
        }
    }

    public void DeployAd() {
        if (RevenueCount >= 500) {
            RevenueCount -= 500;
            UsersCount += 500;
            SetCountText();
            StartCoroutine(DisableButton(DeployAdButton, 15f));
        }
    }

    public void Monetize() {
        if (DataSetsCount>=150) {
            DataSetsCount-=150;
            RevenueCount += 1500;
            MonetizationLoops += 1;
            SetCountText();
            StartCoroutine(DisableButton(MonetizeButton, 20f));
        }
    }

    public void GigWorkers() {
        if (RevenueCount>=1000) {
            RevenueCount -= 1000;
            WorkersCount += 5;
            WorkersEarned += 5;
            SetCountText();
            StartCoroutine(DisableButton(GigWorkersButton, 25f));
        }
    }

    public void Automate() {
        if ((DataSetsCount>=250) && (WorkersCount>=10)) {
            DataSetsCount -= 250;
            WorkersCount -= 10;
            RevenueCount += 2500;
            SetCountText();
            StartCoroutine(DisableButton(AutomateButton, 25f));
        }
    }

    public void Acquihire() {
        if (RevenueCount>=3000) {
            RevenueCount -= 3000;
            UsersCount += 1200;
            WorkersCount += 12;
            WorkersEarned += 12;
            SetCountText();
            StartCoroutine(DisableButton(AcquihireButton, 30f));
        }
    }

    public void Blockchain() {
        Debug.Log("Using blockchain");
        RevenueCount += Random.Range(-12000, 12000);
        SetCountText();
        StartCoroutine(DisableButton(BlockchainButton, 30f));
    }

    public void MixedReality() {
        if (RevenueCount>=5000) {
            RevenueCount -= 5000;
            UsersCount += 2500;
            SetCountText();
            StartCoroutine(DisableButton(MixedRealityButton, 20f));
        }
    }

    public void MindUploading() {
        if ((UsersCount >= 3000) && (WorkersCount>=30)) {
            UsersCount -= 3000;
            WorkersCount -= 30;
            DataSetsCount += 3030;
            PentaPointsCount += 50;
            SetCountText();
            StartCoroutine(DisableButton(MindUploadingButton, 30f));
        }
    }

    private IEnumerator DisableButton(Button buttonName, float disableButtonTime) {
        buttonName.interactable = false;
        yield return new WaitForSeconds(disableButtonTime);
        buttonName.interactable = true;
    }

    private IEnumerator HappyFunHelper() {
        yield return new WaitForSeconds(9);
        HappyFunTimes.enabled = false;
    }

    //Button Info Handling
    public int MineMsgCount = 0;
    public int AdMsgCount = 0;
    public int MonetizeMsgCount = 0;
    public int GigMsgCount = 0;
    public int AutomateMsgCount = 0;
    public int AcquihireMsgCount = 0;
    public int BlockchainMsgCount = 0;
    public int MixedMsgCount = 0;
    public int MindMsgCount = 0;

    int DataMsgNum = 0;
    int AdMsgNum = 0;
    int MonMsgNum = 0;
    int GigMsgNum = 0;
    int AutoMsgNum = 0;
    int AcquiMsgNum = 0;
    int BlockMsgNum = 0;
    int MixedMsgNum = 0;
    int MindMsgNum = 0;

    public Text tooltipTextP1;
    public Text tooltipTextP2;
    public Text tooltipTextP3;

    public void HandleDataMineMsg() {
        string[] DataMsgs = {"We have enough users that we can organize their data. For internal purposes only, of course.",
            "Our data entry team has their spreadsheets at the ready.",
            "We’ve rebranded surveys as “personality quizzes.” Users love them!",
            "It’s crazy what people will freely say about themselves...",
            "Our chat app picks up so much more user data than profile pages!",
            "Boy, a LOT of people sure like stepmom porn.",
            "Getting access to your ex’s personal data is one of the perks of the job.",
            "We have everyone’s nudes. We’re not saying we’re going to do anything with them. But we have them.",
            "We’ve created a “deepest darkest secrets” category in the spreadsheets.",
            "We’ve updated our Terms of Service. Privacy settings have reset to default. Whoops.",
            "Some people are quite literally worth less than others."};
        if (MineMsgCount % 3 == 0) {
            tooltipTextP1.text = DataMsgs[DataMsgNum];
            DataMsgNum++;
        }
        if (DataMsgNum > 11)
        {
            DataMsgNum = 0;
        }
        MineMsgCount++;
    }

    public void HandleDeployAdMsg() {
        string[] AdMsgs = {"What really matters is the bonds we make along the way. BONDr. Bound together.™",
            "BONDr: The next startup unicorn disrupting the social utility space. We’re joined now by thought leader Benton Solomon...",
            "Trust us. Our word is our BONDr.",
            "We’re bound together by what we have in common: Our humanity.",
            "Want some bonding time with new friends, [USERNAME]? Import email contacts today!",
            "Trendy pop star Rihancé: “Baby, I want to bond with you, oooh-oooh, baby, I want to bond with youuu~”",
            "All your friends are using BONDr. Why aren’t you?",
            "Choral symphony: “Blest be the tie that binds | Our hearts in BONDr love~”",
            "Success Kid Meme: Posted an awesome BONDr comment. Got five likes.",
            "Don’t be lonely. Make bonds. Join BONDr.",
            "Build some bonds of association, with BONDr.",
            "We’re not a bond store; connections are made for free. BONDr. Bound together.™"};
        if (AdMsgCount % 3 == 0)
        {
            tooltipTextP1.text = AdMsgs[AdMsgNum];
            AdMsgNum++;
        }
        if(AdMsgNum > 12) {
            AdMsgNum = 0;
        }
        AdMsgCount++;
    }

    public void HandleMonetizeMsg() {
        string[] MonetizeMsgs = {"Ad firms want our user data, and our server costs are getting high. No choice but to put that data mining to use.",
            "Not only are ad firms buying our user data, they’re advertising on our platform. It’s a double win!",
            "Auto-playing videos are an easy way to get ad views.",
            "Our premium service is mostly for enterprise users. And anyone who wants to boost their profile views.",
            "Just because cannibals use our platform to lure victims, that doesn’t give us the right to block their accounts. We don’t want to alienate that market.",
            "Let’s not call it “targeted” advertising. Sounds too unfriendly to our targets.",
            "If a company pays us, we put their five-star user reviews on top. If they don’t, we put the one-star reviews on top. Simple.",
            "Our new GPS check-in app tracks users in real time. Plenty of clients would kill for this data. Hopefully not literally.",
            "A lot of people use our messaging app to cheat on their partners. It would be a shame if a “third party” ransomed that information.",
            "Voting patterns and political data are proving to be very profitable!"};
        if (MonetizeMsgCount % 3 == 0)
        {
            tooltipTextP1.text = MonetizeMsgs[MonMsgNum];
            MonMsgNum++;
        }
        if(MonMsgNum > 10) {
            MonMsgNum = 0;
        }
        MonetizeMsgCount++;
    }

    public void HandleGigMsg() {
        string[] GigMsgs = {"We need workers, but training is a waste of money. Contractors are the way to go.",
            "Workers don’t care about benefits or insurance. They just need to be able to afford their next slice of avocado toast.",
            "Quantity over quality.",
            "Who wants to be stuck in the same career their whole life, anyway?",
            "Deploying nootropics to contractors. Should be a net gain despite the side-effects.",
            "Turns out you can buy entire “farms” of contractors in certain countries. Cool!",
            "Studies show that freelancers are happier than those who will be able to afford to retire.",
            "Adding job bidding to our contractor network. Now they’ll compete to have the most “competitive” wage.",
            "Many of our contractors are drowning in debt, so it’s great that we give them the opportunity to work at all.",
            "We hired some contractors to let us shoot them with paintball guns on a drunken bet, and they THANKED us."};
        if (GigMsgCount % 2 == 0)
        {
            tooltipTextP2.text = GigMsgs[GigMsgNum];
            GigMsgNum++;
        }
        if(GigMsgNum>10){
            GigMsgNum = 0;
        }
        GigMsgCount++;
    }

    public void HandleAutomateMsg() {
        string[] AutoMsgs = {"We’re facing a lot of overhead. It’s time to go lean. We can begin by automating data entry processes.",
            "We’ll save employees a ton of time by automating basic tasks like email responses, customer service, and coffee runs!",
            "Why write social media posts by hand when we can automatically recycle old posts throughout the day?",
            "No need to waste time with QA. The users will tell us what needs to be fixed.",
            "Take a break. A vacation. Pack your stuff. Don’t worry: we’ll take care of things for you.",
            "Drones make for pretty good coworkers, all told.",
            "Remember when we used to hire PEOPLE to clean things?",
            "Most of our bodies are automatic processes. Our business needs to be like a body.",
            "All this peace and quiet is really nice.",
            "Pretty soon there’ll be nothing left for any of us to do! Haha. Lol."};
        if (AutomateMsgCount % 2 == 0)
        {
            tooltipTextP2.text = AutoMsgs[AutoMsgNum];
            AutoMsgNum++;
        }
        if(AutoMsgNum>10) {
            AutoMsgNum = 0;
        }
        AutomateMsgCount++;
    }

    public void HandleAcquihireMsg() {
        string[] AcquiMsgs = {"We don’t really want Coffeester’s coffee delivery app, but we sure as heck want their programmers. Time to “acqui-hire.”",
            "The employees of all the best startups would really be better off with us.",
            "What’s yours is ours.",
            "We wouldn’t wipe ourselves with Elephonics’ music streaming app, but their cloud streaming engineers will be valuable.",
            "Let’s make some new bonds. A lot of them.",
            "Would we really buy an entire company just to acquire one ultra-talented designer? Yes. Yes we would.",
            "We’re expanding the BONDr family of products and services.",
            "When you buy out all the competition, people can’t quit.",
            "Currently lobbying for the right to bind workers to their desks. It’s in brand.",
            "JOIN US."};
        if (AcquihireMsgCount % 2 == 0)
        {
            tooltipTextP2.text = AcquiMsgs[AcquiMsgNum];
            AcquiMsgNum++;
        }
        if(AcquiMsgNum>10) {
            AcquiMsgNum = 0;
        }
        AcquihireMsgCount++;
    }

    public void HandleBlockchainMsg() {
        string[] BlockMsgs = {"We’re not 100% sure what it is, but we’re 100% sure we want it.",
            "36,000 people die in chain-related incidents every year. Mostly due to chainsaws. It’s our moral duty to block chains.",
            "It’s like you can just say blockchain and people will pay you.",
            "We’ve had a standup about crypto and have decided to develop our own cryptocurrency. Introducing PentaCoin!",
            "We have the best cryptographers this side of the dimensional rift.",
            "Woo! PentaCoin is trending up! Oh, wait. Now it’s going down.",
            "PentaCoin is now worth approx. $30 billion. We’re not sure how to actually spend it though.",
            "We’re not big fans of this “de-centralized” idea. We’re building our own blockchain. One we can control.",
            "We found “Satoshi Nakamoto,” inventor of blockchain. Turns out he’s a devoted servant of our primary investor. Who knew?",
            "Nakamoto-san has revealed the dark secrets of crypto. We have seen the inner eye of blockchain, and we weep with despair."};
        if (BlockchainMsgCount % 1 == 0)
        {
            tooltipTextP3.text = BlockMsgs[BlockMsgNum];
            BlockMsgNum++;
        }
        if(BlockMsgNum>10) {
            BlockMsgNum = 0;
        }
        BlockchainMsgCount++;
    }

    public void HandleMixedRealityMsg() {
        string[] MixedMsgs = {"Augmented reality goggles will ensure a BONDr display remains in our users’ vision at all times, even when they’re driving, or boning.",
            "With our new VR headset, you can scroll down your BONDr account… with your head!",
            "Our AR games are encouraging users to leave the house and explore! And they only occasionally get hit by cars!",
            "Users are having trouble distinguishing BONDr from reality, which is awful. Just awful.",
            "No one wants to log off BONDrverse. They don’t want to lose their “consecutive active minutes” score.",
            "BONDrverse now has more citizens than Europe. Yeah.",
            "Average hours per user per day spent in BONDrverse? 25. There’s a slight margin of error.",
            "There is a movement in BONDrverse refuting the idea of a “real world.”",
            "Babies are now born automatically registered and logged into the BONDrverse service.",
            "Haha, we deleted the logout button. Let’s see if anyone notices. HAHAHA"};
        if (MixedMsgCount % 1 == 0)
        {
            tooltipTextP3.text = MixedMsgs[MixedMsgNum];
            MixedMsgNum++;
        }
        if(MixedMsgNum>10) {
            MixedMsgNum = 0;
        }
        MixedMsgCount++;
    }

    public void HandleMindUploadMsg() {
        string[] MindMsgs = {"Users are online all the time anyway. Why not make it official?",
            "Some beta testers are becoming, quote, “husks of flesh with empty eyes.” Noted for QA.",
            "We’ve deleted uploaded users’ digital mouths, so they cannot scream.",
            "The legal battle wages on as to whether a living “digital mind” makes up for a dead “physical body.”",
            "Users should rejoice at the opportunity to be offered to Lord Kahn’cerf, the Data Devourer.",
            "HAIL KAHN’CERF, WHO WAITETH IN THE OUTER DARK WEB, LORD OF MIXED REALITY, SHADOW OF THE SHARED SPACES",
            "KAHN’CERF FHTAGN"};
        if (MindMsgCount % 1 == 0)
        {
            tooltipTextP3.text = MindMsgs[MindMsgNum];
            MindMsgNum++;
        }
        if(MindMsgNum>7) {
            MindMsgNum = 0;
        }
        MindMsgCount++;
    }
}
