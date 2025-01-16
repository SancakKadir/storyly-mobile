package com.example.storylyjetpackcompose

import android.os.Bundle
import android.util.Log
import android.view.Surface
import android.view.View
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.WindowInsets
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.navigationBars
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.safeContentPadding
import androidx.compose.foundation.layout.safeDrawingPadding
import androidx.compose.material.MaterialTheme
import androidx.compose.material.MaterialTheme.colors
import androidx.compose.material.Scaffold
import androidx.compose.material.Surface
import androidx.compose.material.Text
import androidx.compose.material.TopAppBar
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.unit.dp
import androidx.compose.ui.viewinterop.AndroidView
import androidx.core.view.WindowCompat
import com.appsamurai.storyly.*
import com.appsamurai.storyly.analytics.StorylyEvent
import com.appsamurai.storyly.config.StorylyConfig
import com.appsamurai.storyly.config.styling.group.StorylyStoryGroupStyling
import com.appsamurai.storyly.config.styling.story.StorylyStoryStyling
import com.appsamurai.storyly.verticalfeed.StorylyVerticalFeedInit
import com.appsamurai.storyly.verticalfeed.StorylyVerticalFeedPresenterView
import com.appsamurai.storyly.verticalfeed.config.StorylyVerticalFeedConfig
import com.appsamurai.storyly.verticalfeed.config.customization.StorylyVerticalFeedCustomization
import com.example.storylyjetpackcompose.ui.theme.StorylyJetpackComposeTheme

class MainActivity : ComponentActivity() {


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        WindowCompat.setDecorFitsSystemWindows(window, false) // Enable full-screen mode
        window.statusBarColor = android.graphics.Color.TRANSPARENT
        val view = StorylyVerticalFeedPresenterView(this)
        view.play()

        view.storylyVerticalFeedInit =
            StorylyVerticalFeedInit(
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjEwNTgzLCJhcHBfaWQiOjE2MzY0LCJpbnNfaWQiOjIyOTc2fQ.j-0i42xojeP1OPXNX2JE7-wdFDXtdeOY437Icv-5RH4",
                StorylyVerticalFeedConfig.Builder()
                    .setVerticalFeedStyling(
                        StorylyVerticalFeedCustomization.Builder()
                            .setCloseButtonVisibility(false)
                            .setLikeButtonVisibility(false)
                            .build()
                    )
                    .build()
            )

        setContent {
            StorylyJetpackComposeTheme() {
                subHomeComponent(view)
            }
        }
    }
}

@Composable
fun subHomeComponent(view: View) {
    Scaffold(contentWindowInsets = WindowInsets.navigationBars) { paddingValues ->
        Surface(modifier = Modifier.padding(bottom = paddingValues.calculateBottomPadding())) {
            Box(Modifier.fillMaxSize()) {
                AndroidView(
                    modifier = Modifier.fillMaxSize(),
                    factory = { view }
                )
            }
        }
    }
}