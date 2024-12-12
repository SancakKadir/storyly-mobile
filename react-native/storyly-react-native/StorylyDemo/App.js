/**
 * Sample React Native App
 *
 * adapted from App.js generated by the following command:
 *
 * react-native init example
 *
 * https://github.com/facebook/react-native
 */

import React, { Component, useState, useRef, useEffect } from 'react';
import { View, Image, Text, PixelRatio, ScrollView, TouchableOpacity, Animated } from 'react-native';
import { Storyly } from 'storyly-react-native';
import { VerticalFeedBar } from 'storyly-react-native';
import { VerticalFeed } from 'storyly-react-native';
import { VerticalFeedPresenter } from 'storyly-react-native';
import { Dimensions } from 'react-native'

const PIN_ICON = require('./assets/pin_icon.png');


const STORYLY_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjU1NiwiYXBwX2lkIjoxMzg5LCJpbnNfaWQiOjE4NjY1fQ._PwkZ48JdHkSU01KUR2n66zJcL29JhykNTMRUorfvE4"

export default class App extends Component {
    constructor(props) {
        super(props);

        this.state = {
            isHidden: false,
        };
    }

    render() {
        return (
            <View>
                <ScrollView>
                    <ShowHideAnimation style={{ width: "100%", height: Dimensions.get('window').height - 50 }} isHidden={this.state.isHidden} >
                        <VerticalFeedPresenter
                            ref={ref => { this.verticalFeedPresenter = ref }}
                            style={{ width: '100%', height: Dimensions.get('window').height, backgroundColor: "#00ffff" }}
                            storylyId={"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjIzODAsImFwcF9pZCI6MjA1MTEsImluc19pZCI6MjI5NDJ9.TXCs-M6guskLJA1JXmu7PlmPxUKfyw88lBpOdxmgpDI"}
                            onLoad={loadEvent => {
                                console.log(`[Vertical Feed Presenter] - onLoad`);
                                this.verticalFeedPresenter.resumeStory()
                            }}
                            onEvent={ verticalFeedEvent => {
                                console.log(`[Vertical Feed Presenter] - onEvent ${verticalFeedEvent.event} ${verticalFeedEvent.feedGroup.toString()}`);
                            }}
                            onCartUpdate={ StoryProductCartUpdateEvent => {
                                console.log(`[Vertical Feed Presenter] - onCartUpdate ${StoryProductCartUpdateEvent.event} ${StoryProductCartUpdateEvent.change.toString()}`);
                            }}
                            onUserInteracted={ VerticalFeedItemInteractiveEvent => {
                                console.log(`[Vertical Feed Presenter] - onUserInteracted ${VerticalFeedItemInteractiveEvent.storyComponent}`);
                            }}
                            onPress={ VerticalFeedPressEvent => {
                                console.log(`[Vertical Feed Presenter] - onPress ${VerticalFeedPressEvent.feedItem}`);
                            }} />
                    </ShowHideAnimation>

                    <TouchableOpacity onPress={() => { this.setState({isHidden: !this.state.isHidden}) }}>
                        <View style={{ padding: 10, backgroundColor: 'blue' }}>
                            <Text style={{ color: 'white', textAlign: "center" }}>{this.state.isHidden ? 'Show Presenter' : 'Hide Presenter'}</Text>
                        </View>
                    </TouchableOpacity>

                    <Storyly
                        style={{ width: '100%', height: 100, marginTop: 10, backgroundColor: "#00ffff" }}
                        storylyId={STORYLY_TOKEN}
                        storyGroupSize="small"
                        storyHeaderShareIcon={"share_icon"}
                        storyHeaderCloseIcon={"close_icon"}
                        storyItemTextTypeface={"Lobster1.4.otf"}
                        storyInteractiveTextTypeface={"Lobster1.4.otf"}
                        storyItemProgressBarColor={["#00FF00", "#FF0000"]}
                        storyItemIconBorderColor={["#FF0000", "#FF0000"]}
                        onLoad={loadEvent => {
                            console.log(`[Storyly] default - onLoad`);
                        }} />
                    <Storyly
                        style={{ width: '100%', height: 120, marginTop: 10, backgroundColor: "#7fff00" }}
                        storylyId={STORYLY_TOKEN}
                        storyGroupSize="large" />
                    <Storyly
                        ref={ref => { this.customStoryly = ref }}
                        style={{ width: '100%', height: 170, marginTop: 10, backgroundColor: "#e9967a" }}
                        storylyId={STORYLY_TOKEN}
                        storyGroupSize="custom"
                        storyGroupIconHeight={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(80) : 80}
                        storyGroupIconWidth={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(80) : 80}
                        storyGroupIconCornerRadius={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(20) : 20}
                        storyGroupListHorizontalEdgePadding={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(20) : 20}
                        storyGroupListHorizontalPaddingBetweenItems={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(10) : 10}
                        storyGroupTextTypeface={"Lobster1.4.otf"}
                        storyGroupTextSize={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(20) : 20}
                        storyGroupTextLines={3}
                        storyGroupTextColorSeen={"#00FF00"}
                        storyGroupTextColorNotSeen={"#FF0000"}
                        storyGroupIconBorderColorNotSeen={["#FF0000", "#FF0000"]}
                        storyGroupIconBorderColorSeen={["#FFFFFF", "#FFFFFF"]}
                        storyGroupIconBackgroundColor={"#000000"}
                        storyGroupPinIconColor={"#000000"} />
                    <VerticalFeedBar
                        ref={ref => { this.verticalFeedBar = ref }}
                        verticalFeedGroupIconHeight={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(200) : 200}
                        style={{ width: '100%', height: 250, marginTop: 10, backgroundColor: "#ff00ff" }}
                        onLoad={loadEvent => {
                            console.log(`[Vertical Feed Bar] - onLoad`);
                        }}
                        onEvent={ verticalFeedEvent => {
                            console.log(`[Vertical Feed Bar] - onEvent ${verticalFeedEvent.event} ${verticalFeedEvent.feedGroup.toString()}`);
                        }}
                        onCartUpdate={ StoryProductCartUpdateEvent => {
                            console.log(`[Vertical Feed Bar] - onCartUpdate ${StoryProductCartUpdateEvent.event} ${StoryProductCartUpdateEvent.change.toString()}`);
                        }}
                        onUserInteracted={ VerticalFeedItemInteractiveEvent => {
                            console.log(`[Vertical Feed Bar] - onUserInteracted ${VerticalFeedItemInteractiveEvent.storyComponent}`);
                        }}
                        onPress={ VerticalFeedPressEvent => {
                            console.log(`[Vertical Feed Bar] - onPress ${VerticalFeedPressEvent.feedItem}`);
                        }}
                        storyGroupIconCornerRadius={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(0) : 0}
                        storylyId={"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjIzODAsImFwcF9pZCI6MjA1MTEsImluc19pZCI6MjI5NDJ9.TXCs-M6guskLJA1JXmu7PlmPxUKfyw88lBpOdxmgpDI"}/>
                    <VerticalFeed
                        ref={ref => { this.verticalFeed = ref }}
                        verticalFeedGroupListSections={2}
                        verticalFeedGroupIconHeight={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(200) : 200}
                        style={{ width: '100%', height: 750, marginTop: 10}}
                        onLoad={loadEvent => {
                            console.log(`[Vertical Feed] - onLoad`);
                        }}
                        onEvent={ verticalFeedEvent => {
                            console.log(`[Vertical Feed] - onEvent ${verticalFeedEvent.event} ${verticalFeedEvent.feedGroup.toString()}`);
                        }}
                        onCartUpdate={ StoryProductCartUpdateEvent => {
                            console.log(`[Vertical Feed] - onCartUpdate ${StoryProductCartUpdateEvent.event} ${StoryProductCartUpdateEvent.change.toString()}`);
                        }}
                        onUserInteracted={ VerticalFeedItemInteractiveEvent => {
                            console.log(`[Vertical Feed] - onUserInteracted ${VerticalFeedItemInteractiveEvent.storyComponent}`);
                        }}
                        onPress={ VerticalFeedPressEvent => {
                            console.log(`[Vertical Feed] - onPress ${VerticalFeedPressEvent.feedItem}`);
                        }}
                        storyGroupIconCornerRadius={Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(0) : 0}
                        storylyId={"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjIzODAsImFwcF9pZCI6MjA1MTEsImluc19pZCI6MjI5NDJ9.TXCs-M6guskLJA1JXmu7PlmPxUKfyw88lBpOdxmgpDI"}/>
                </ScrollView>
            </View>
        );
    }
}

const convertToNative = (size) => {
    return Platform.OS === 'android' ? PixelRatio.getPixelSizeForLayoutSize(size) : size
}


const CustomPortraitView = ({ storyGroup }) => {
    return (
        <>
            {(storyGroup ? (
                <View style={{ width: 100, height: 178 }}>
                    <Image style={{
                        width: "100%",
                        height: "100%",
                        borderRadius: 8
                    }}
                        source={{ uri: storyGroup.iconUrl }} />
                    <View style={{ width: 100, height: 168, borderRadius: 8, position: 'absolute', backgroundColor: storyGroup.seen ? "#16ad055f" : "#1905ad5f" }}>
                        <View style={{ flexDirection: 'column', width: 90, marginTop: 20, marginLeft: 5, height: "100%", alignItems: 'center', justifyContent: 'flex-start' }}>
                            {storyGroup.pinned ?
                                <Image style={{ width: 20, height: 20, marginTop: 5, marginBottom: 10, borderRadius: 10 }} source={PIN_ICON} /> : <View style={{ width: 20, height: 20, marginTop: 5, marginBottom: 10 }} />}
                            <Text style={{ flexWrap: 'wrap', width: "90%", textAlign: 'center', fontWeight: 'bold', fontSize: 15, color: "white" }}>{storyGroup.title}</Text>
                        </View>
                    </View>
                </View>
            ) : (
                <View style={{ width: "100%", height: "100%", borderRadius: 8 }}></View>
            ))}
        </>
    )
}


const ShowHideAnimation = (props) => {
    const heightAnim = useRef(new Animated.Value(0)).current;

    useEffect(() => {
        Animated.timing(heightAnim, {
            toValue: props.isHidden ? 0 : props.style.height,
            duration: 500,
            useNativeDriver: false,
        }).start();
    }, [props.isHidden])

    return (
        <Animated.View style={{ height: heightAnim, overflow: 'hidden' }}>
            {props.children}
        </Animated.View>
    );
};

Object.prototype.toString = function(){
    return JSON.stringify(this)
  }