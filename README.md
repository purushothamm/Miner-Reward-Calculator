# Miner-Reward-Calculator
This is a Blockchain miner reward calculator program. Program accepts number of Bytes and Fee of Transactions to be included in a Block and calculates the maximum reward by gathering best transactions with Fee per Byte.

To calculate Fee per Bytes we need number of bytes and fee of transaction. The standard way of getting max reward is by gathering transactions having more Fee per Bytes, usually sender can specify highest fee for transaction and miners are interested in processing highest fee transactions first.

Bitcoin transactions vary in size for a variety of reasons with vary in fee specified by senders and there is no required selection methods to select which transactions to include, but one strategy popular among miners is for each individual miner to attempt to maximize the amount of fee income they can collect from the transactions they include in their blocks(4). 

some Important facts about Bitcoin blockchain;

Bitcoin has a maximum block size of 1Mb in 2020 and the size may increase in coming years (1) but blocks are not produced on a fixed schedule, in average system targets on block for every 10 minutes. 

In April 15 2019 average number of bitcoin transactions per block reached an all-time high of 2,768 transactions(2) and In Jul 12 2020 Bitcoin blockchain size was 288.26 GB and is steadily increasing(3)

Resources:
(1)https://coinmetrics.io/what-should-we-expect-from-bitcoins-block-size-in-the-coming-years/
(2)https://ycharts.com/indicators/bitcoin_average_transactions_per_block
(3)https://www.blockchain.com/charts/blocks-size
(4)https://en.bitcoin.it/wiki/Miner_fees#:~:text=Including%20in%20Blocks,-This%20section%20describes&text=Then%20transactions%20that%20pay%20a,more%20than%20750%2C000%20bytes%20big.&text=Transactions%20are%20added%20highest%2Dpriority,this%20section%20of%20the%20block.

Project detail:
Project is developed using Visual Studio 2019, Windows Forms App (.NET Framework) and Coded in C#.

Prerequisites: 
Prerequisites are already added into the build

Running:
Download Project and Open in Visual Studio 2019, Build and run the project. One can also run the project directly through EXE file in Debug folder of Project part at ‘’Project folder path”\MinerFeeCalc\bin\Debug
