import React from 'react'

import { GroupedColumn } from '@antv/g2plot';

const data = [
    {
        name: 'London',
        月份: 'Jan.',
        月均降雨量: 18.9,
    },
    {
        name: 'London',
        月份: 'Feb.',
        月均降雨量: 28.8,
    },
    {
        name: 'London',
        月份: 'Mar.',
        月均降雨量: 39.3,
    },
    {
        name: 'London',
        月份: 'Apr.',
        月均降雨量: 81.4,
    },
    {
        name: 'London',
        月份: 'May',
        月均降雨量: 47,
    },
    {
        name: 'London',
        月份: 'Jun.',
        月均降雨量: 20.3,
    },
    {
        name: 'London',
        月份: 'Jul.',
        月均降雨量: 24,
    },
    {
        name: 'London',
        月份: 'Aug.',
        月均降雨量: 35.6,
    },
    {
        name: 'Berlin',
        月份: 'Jan.',
        月均降雨量: 12.4,
    },
    {
        name: 'Berlin',
        月份: 'Feb.',
        月均降雨量: 23.2,
    },
    {
        name: 'Berlin',
        月份: 'Mar.',
        月均降雨量: 34.5,
    },
    {
        name: 'Berlin',
        月份: 'Apr.',
        月均降雨量: 99.7,
    },
    {
        name: 'Berlin',
        月份: 'May',
        月均降雨量: 52.6,
    },
    {
        name: 'Berlin',
        月份: 'Jun.',
        月均降雨量: 35.5,
    },
    {
        name: 'Berlin',
        月份: 'Jul.',
        月均降雨量: 37.4,
    },
    {
        name: 'Berlin',
        月份: 'Aug.',
        月均降雨量: 42.4,
    },
];

export default class IEGroupedColumnDemo extends React.Component {
    componentDidMount(){
        const columnPlot = new GroupedColumn(document.getElementById('IEGroupedColumnDemo'), {
            // title: {
            //     visible: true,
            //     text: '分组柱状图',
            // },
            forceFit: true,
            data,
            xField: '月份',
            yField: '月均降雨量',
            yAxis: {
                min: 0,
            },
            label: {
                visible: true,
            },
            groupField: 'name',
            color: ['#1ca9e6', '#f88c24'],
        });
        
        columnPlot.render();
    }

    render() {
        return <div id="IEGroupedColumnDemo"></div>
    }
}