﻿import { defineComponent, inject } from '../../Vendor/Vue/vue.js';
import PaneledBlockTemplate from '../../Templates/PaneledBlockTemplate.js';
import Loading from '../../Controls/Loading.js';
import { BlockAction } from '../../Controls/RockBlock.js';
import { BlockSettings } from '../../Index.js';
import store from '../../Store/Index.js';
import { Guid } from '../../Util/Guid.js';
import JavaScriptAnchor from '../../Elements/JavaScriptAnchor.js';
import RockForm from '../../Controls/RockForm.js';
import TextBox from '../../Elements/TextBox.js';
import RockButton from '../../Elements/RockButton.js';
import AttributeValueContainer from '../../Controls/AttributeValueContainer.js';
import AttributeValue from '../../ViewModels/CodeGenerated/AttributeValueViewModel.js';
import Person from '../../ViewModels/CodeGenerated/PersonViewModel.js';
import Attribute from '../../ViewModels/CodeGenerated/AttributeViewModel.js';

type ViewModel = {
    Attribute: Attribute,
    Value: string | null
};

export default defineComponent({
    name: 'Crm.AttributeValues',
    components: {
        PaneledBlockTemplate,
        Loading,
        JavaScriptAnchor,
        RockForm,
        TextBox,
        RockButton,
        AttributeValueContainer
    },
    setup() {
        return {
            blockAction: inject('blockAction') as BlockAction,
            blockSettings: inject('blockSettings') as BlockSettings
        };
    },
    data() {
        return {
            isLoading: true,
            isEditMode: false,
            viewModels: [] as ViewModel[]
        };
    },
    computed: {
        personGuid(): Guid | null {
            const person = (store.getters.personContext || null) as Person | null;
            return person ? person.Guid : null;
        },
        useAbbreviatedNames(): boolean {
            return this.blockSettings.UseAbbreviatedNames as boolean;
        }
    },
    methods: {
        goToViewMode() {
            this.isEditMode = false;
        },
        goToEditMode() {
            this.isEditMode = true;
        },
        async loadData() {
            if (!this.personGuid) {
                this.viewModels = [];
                return;
            }

            try {
                this.isLoading = true;
                const result = await this.blockAction<ViewModel[]>('GetAttributeValueList', {
                    PersonGuid: this.personGuid
                });

                if (result.data) {
                    this.viewModels = result.data;
                }
            }
            finally {
                this.isLoading = false;
            }
        },
        async doSave(): Promise<void> {
            this.isLoading = true;

            const keyValueMap = {};

            for (const a of this.viewModels) {
                keyValueMap[a.Attribute.Key] = a.Value;
            }

            await this.blockAction('SaveAttributeValues', {
                personGuid: this.personGuid,
                keyValueMap
            });

            this.goToViewMode();
            this.isLoading = false;
        }
    },
    watch: {
        personGuid: {
            immediate: true,
            async handler() {
                if (this.personGuid) {
                    await this.loadData();
                }
            }
        }
    },
    template: `
<PaneledBlockTemplate class="panel-persondetails">
    <template v-slot:title>
        <i :class="blockSettings.BlockIconCssClass"></i>
        {{ blockSettings.BlockTitle }}
    </template>
    <template v-slot:titleAside>
        <div class="actions rollover-item pull-right">
            <JavaScriptAnchor title="Order Attributes" class="btn-link edit">
                <i class="fa fa-bars"></i>
            </JavaScriptAnchor>
            <JavaScriptAnchor title="Edit Attributes" class="btn-link edit" @click="goToEditMode">
                <i class="fa fa-pencil"></i>
            </JavaScriptAnchor>
        </div>
    </template>
    <template v-slot:default>
        <Loading :isLoading="isLoading">
            <AttributeValueContainer v-if="!isEditMode" :attributeValues="viewModels" :showEmptyValues="false" />
            <RockForm v-else @submit="doSave">
                <AttributeValueContainer :attributeValues="viewModels" isEditMode :showAbbreviatedName="useAbbreviatedNames" />
                <div class="actions">
                    <RockButton class="btn-primary btn-xs" type="submit">Save</RockButton>
                    <RockButton class="btn-link btn-xs" @click="goToViewMode">Cancel</RockButton>
                </div>
            </RockForm>
        </Loading>
    </template>
</PaneledBlockTemplate>`
});
